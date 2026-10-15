using System.Runtime.InteropServices;
using Executor.Models;
using static LibcWrapper.Methods;

namespace Executor;

public class Executor
{
    private const int EINTR = 4;

    /// <summary>Spawns <paramref name="command"/> with posix_spawnp, waits for it and returns the shell-style exit code.</summary>
    public unsafe int ExecuteCommand(Command command)
    {
        // argv = [name, ...args, NULL]
        string[] argv = [command.name, ..command.args];
        string[] envp = [..Environment.GetEnvironmentVariables()
            .Cast<System.Collections.DictionaryEntry>()
            .Select(e => $"{e.Key}={e.Value}")];

        sbyte** cArgv = null;
        sbyte** cEnvp = null;
        try
        {
            cArgv = ToCStringArray(argv);
            cEnvp = ToCStringArray(envp);

            int pid;
            // file_actions / attr are optional; NULL means "inherit everything, default attributes"
            int s = posix_spawnp(&pid, cArgv[0], null, null, cArgv, cEnvp);
            if (s != 0)
            {
                // posix_spawn returns the error number instead of setting errno
                Console.Error.WriteLine($"clash: {command.name}: {Marshal.GetPInvokeErrorMessage(s)}");
                return s == 2 ? 127 : 126; // ENOENT -> 127, otherwise 126
            }

            return WaitForChild(pid);
        }
        finally
        {
            FreeCStringArray(cArgv);
            FreeCStringArray(cEnvp);
        }
    }

    private static unsafe int WaitForChild(int pid)
    {
        int status;
        while (waitpid(pid, &status, 0) == -1)
        {
            if (Marshal.GetLastSystemError() != EINTR)
                throw new InvalidOperationException($"waitpid failed: errno {Marshal.GetLastSystemError()}");
        }

        int termSig = status & 0x7f;
        if (termSig == 0) return (status >> 8) & 0xff; // WIFEXITED -> WEXITSTATUS
        return 128 + termSig;                          // WIFSIGNALED -> bash convention
    }

    private static unsafe sbyte** ToCStringArray(string[] items)
    {
        var arr = (sbyte**)NativeMemory.AllocZeroed((nuint)(items.Length + 1), (nuint)sizeof(sbyte*));
        for (int i = 0; i < items.Length; i++)
            arr[i] = (sbyte*)Marshal.StringToCoTaskMemUTF8(items[i]);
        return arr; // last slot stays NULL
    }

    private static unsafe void FreeCStringArray(sbyte** arr)
    {
        if (arr == null) return;
        for (sbyte** p = arr; *p != null; p++)
            Marshal.FreeCoTaskMem((IntPtr)(*p));
        NativeMemory.Free(arr);
    }
}
