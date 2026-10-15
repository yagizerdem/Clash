namespace Executor.Models;

public class Command
{
    public string name { get; set; }

    public string[] args { get; set; } = [];

    public Command(string name,  string[] args)
    {
        this.name = name;
        this.args = args;
    }
}