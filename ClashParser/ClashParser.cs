using Clash.Bash;

namespace Clash.Parser;

public class ClashParser
{
    
    public void Parse(string command)
    {
        Console.WriteLine(ParseAndSerializeTStree(command));
    }

    public TreeSitter.Tree ParseAndReturnTree(string command)
    {
        BashParser bashParser = new BashParser();
        var tree = bashParser.Parse(command);
        return tree;
    }

    public string ParseAndSerializeTStree(string command)
    {
        var tree = ParseAndReturnTree(command);
        return tree.RootNode.ToString();    
    }

}
