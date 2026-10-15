# clash

A Unix/bash-like interactive shell written in C# (.NET 10, `net10.0`, nullable enabled).

## Layout

- `clash.slnx` – solution file
- `App/` – console app (REPL host, entry point)
- `ClashParser/` – class library (lexer / parser / AST)
- `BashParser/` – class library (tree sitter bash compability and syntax error detection layer)
- `Clash.Ast/` – class library (AST node definitions)

Keep shell logic in class libraries; `app` only hosts the REPL. Run with `dotnet run --project app`.

## Skills to use (`.claude/skills/`)

- `dotnet-shell-implementation` – architecture, POSIX expansion order, .NET process/pipe/signal pitfalls, milestone order. Load for any shell feature work.
- `dotnet-csharp` + `modern-csharp` – baseline for all C# code (C# 14 idioms, async, P/Invoke via `references/native-interop.md`).
- `dotnet-testing` – xUnit v3 tests for lexer/parser/expansion.
- `shell-expert` – reference for how bash/POSIX behaves.
- `cli-developer` – REPL/terminal UX (TTY detection, Ctrl+C, stderr vs stdout).
- `dotnet-debugging` – hangs/crashes (lldb, dotnet-dump).
- `commit-message` – use for every commit.

## Conventions

- Commits: semantic format via the `commit-message` skill, lowercase subject. **Never add `Co-Authored-By` or any Claude attribution trailers** to commits or PRs.
- The user writes in Turkish; reply in Turkish.
