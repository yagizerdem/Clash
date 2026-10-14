using Clash.Bash;

namespace Clash.Parser;

public class ClashParser
{
    
    public void parse(string command)
    {
        Console.WriteLine(parseAndSerializeTStree(command));
    }

    public TreeSitter.Tree parseAndReturnTree(string command)
    {
        BashParser bashParser = new BashParser();
        var tree = bashParser.Parse(command);
        return tree;
    }

    public string parseAndSerializeTStree(string command)
    {
        var tree = parseAndReturnTree(command);
        return tree.RootNode.ToString();    
    }

}
