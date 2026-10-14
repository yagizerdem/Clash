---
name: dotnet-shell-implementation
description: Architecture and pitfalls for implementing a Unix/bash-like interactive shell in C#/.NET (the clash project). Use when working on the shell's lexer, parser, AST, word expansion (variables, quoting, globbing, command substitution), command execution, pipelines, redirections, builtins (cd, export, exit, jobs...), environment, exit codes, signals (Ctrl+C, SIGCHLD), job control, or the line editor/REPL.
---

# Implementing a bash-like shell in .NET

Reference behavior: POSIX Shell Command Language (IEEE Std 1003.1, "Shell & Utilities" vol., ch. 2) and the GNU Bash manual. When unsure how something should behave, check what `bash` does by running it.

## Pipeline of stages

Keep these as separate, testable components (separate classes / ideally a class library, with the console app only hosting the REPL):

1. **Reader / line editor** – reads a line (or more, for unterminated quotes, `\` continuations, `if ... fi` blocks). Prompt `PS1`/`PS2`.
2. **Lexer** – produces tokens: `WORD`, operators (`|`, `||`, `&&`, `;`, `&`, `(`, `)`, `<`, `>`, `>>`, `<<`, `<<-`, `>&`, `<&`, `<>`, `>|`), `IO_NUMBER` (the `2` in `2>file`), `NEWLINE`, `EOF`. Words keep their *raw* text including quotes — quote removal happens later, during expansion. Use lexer modes (inside `'...'`, `"..."`, `$(...)`, `${...}`, `` `...` ``) rather than one big regex.
3. **Parser** – recursive descent over the POSIX grammar: `list → and_or ((';'|'&') and_or)*`, `and_or → pipeline (('&&'|'||') pipeline)*`, `pipeline → ['!'] command ('|' command)*`, `command → simple_command | compound_command redirect*`. Reserved words (`if then else elif fi while until for in do done case esac { }`) are only recognized in command position.
4. **AST** – model with records / sealed hierarchy (`SimpleCommand`, `Pipeline`, `AndOr`, `Sequence`, `Subshell`, `BraceGroup`, `If`, `While`, `For`, `Case`, `FunctionDef`, `Redirection`). Pattern-match over it in the executor.
5. **Expansion** (in this exact order, per word): brace expansion (bash) → tilde → parameter/variable (`$x`, `${x:-def}`, `$?`, `$$`, `$#`, `$@`, `$*`, `$0..$9`) → command substitution `$(...)` → arithmetic `$((...))` → **field splitting on `IFS`** (only on unquoted expansion results) → pathname expansion / globbing (`*`, `?`, `[...]`, only unquoted) → quote removal. Track per-character "quoted" flags through expansion; that is what makes `"$x"` vs `$x` and `"*"` vs `*` work.
6. **Executor** – runs the AST, sets `$?`.

## Execution in .NET: key constraints

- **There is no `fork()` in .NET.** Don't P/Invoke `fork` from a managed process (runtime threads make it unsafe). Use `System.Diagnostics.Process` (it uses `posix_spawn`/fork+exec internally) or P/Invoke `posix_spawn` yourself if you need full fd control.
- **Subshells `( ... )` and `$(...)`** cannot fork the interpreter: run them in-process with a *copied* shell state (variables, cwd, fds), capturing output to a buffer/stream for command substitution.
- **Builtins must run in-process**: `cd`, `export`, `unset`, `exit`, `set`, `alias`, `source`/`.`, `read`, `jobs`, `fg`, `bg`, `wait` change shell state. Commonly also `echo`, `pwd`, `true`, `false`, `test`/`[` for speed. In a pipeline, a builtin that isn't the last stage would run in a subshell in bash (so `echo x | cd /` doesn't change cwd) — emulate by running it on a copied state.
- **Command lookup**: function → builtin → `PATH` search (split on `:`, check file exists and is executable — `File.GetUnixFileMode` / `UnixFileMode.UserExecute` etc.). Cache in a hash table (`hash` builtin). Exit code 127 for not found, 126 for not executable.
- **`ProcessStartInfo`**: set `UseShellExecute = false`, add arguments via `ArgumentList` (never build a single argument string — words are already split), set `WorkingDirectory` to the shell's cwd, and copy the shell's *exported* variables into `Environment` (clear it first).
- **Pipelines**: start all stages, connect stage *n* stdout to stage *n+1* stdin by copying streams (`RedirectStandardOutput/Input` + `Stream.CopyToAsync`), close the writer when the producer ends so the consumer sees EOF. Exit status of a pipeline = last command's (or use `pipefail`). Note `Process` stream redirection means child stdout is a pipe, not a TTY — programs like `ls` change formatting, and interactive programs (`vim`, `less`) break if redirected. Only redirect what you must; leave stdin/stdout/stderr inherited when not piped/redirected. For true fd-level pipes (and `2>&1`), P/Invoke `pipe`, `dup2`, `posix_spawn_file_actions_*` in `libc`.
- **Redirections**: `>`/`>>`/`<` open `FileStream`s; apply left to right (`cmd >f 2>&1` ≠ `cmd 2>&1 >f`). For builtins, redirect the shell's own `TextWriter`s temporarily (abstract stdout/stderr behind an interface instead of using `Console` directly — also makes testing easy).
- **Exit codes**: `$?`; killed by signal N → 128+N. `!` inverts. `&&`/`||` short-circuit on exit code 0.

## Signals and interactivity

- Ctrl+C: use `PosixSignalRegistration.Create(PosixSignal.SIGINT, ctx => { ctx.Cancel = true; ... })` so the shell itself doesn't die; the foreground child receives SIGINT from the terminal on its own because it's in the same process group. Ignore SIGQUIT / SIGTSTP in the shell.
- Full job control (`&`, `jobs`, `fg`, `bg`, Ctrl+Z) requires process groups and terminal ownership (`setpgid`, `tcsetpgrp`, `waitpid(WUNTRACED)`), which `Process` does not expose → needs P/Invoke into libc. Implement background `&` + `jobs` + `wait` first with `Process`, treat Ctrl+Z/`fg`/`bg` as a later P/Invoke milestone.
- Line editing: `Console.ReadKey(intercept: true)` for history (↑/↓), cursor movement, tab completion. Or start with `Console.ReadLine()`. `Console.TreatControlCAsInput` affects Ctrl+C handling during reading.
- Non-interactive mode: `clash script.sh` and `clash -c "cmd"`; when stdin is not a TTY (`Console.IsInputRedirected`), don't print prompts.

## Testing

- Unit-test lexer (input → token list), parser (input → AST, compare records), and expansion separately with xUnit `[Theory]` data rows.
- Integration tests: run scripts through the shell and compare stdout/exit code with real `bash --posix` output for the same script (differential testing).
- Edge cases to always cover: empty input, only whitespace/comments, unterminated quotes, `a=1 cmd` (temp env assignment), `"$@"` with spaces, empty `IFS`, glob with no matches (stays literal in POSIX), `cd` with no args (→ `$HOME`), `cd -`, `exit` with code, trailing `&`/`;`, `2>&1` ordering.

## Suggested milestone order

1. REPL + run external commands with args (quoting `'`/`"`/`\`).
2. Builtins: `exit`, `cd`, `pwd`, `echo`, `export`, `unset`.
3. Variables & `$?`, env passing.
4. Redirections, then pipelines.
5. `&&`, `||`, `;`, `!`.
6. Globbing, tilde, command substitution.
7. Control flow (`if`, `while`, `for`, `case`), functions, scripts.
8. History / line editing / tab completion.
9. Background jobs, then full job control via P/Invoke.
