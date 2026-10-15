namespace Runtime;

public class Core
{

    public Core()
    {
    }

    public void Run()
    {
        Executor.Executor executor = new Executor.Executor();
        executor.ExecuteCommand(new Executor.Models.Command("echo", ["fucker"]));
    }
}
