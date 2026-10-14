using TreeSitter;

namespace Clash.Bash;

public class BashParser
{
    public TreeSitter.Tree Parse(string input)
    {
        using var language = new Language("Bash");
        using var parser = new Parser(language);
        var tree = parser.Parse(input)!;
        return tree;
    }
}
