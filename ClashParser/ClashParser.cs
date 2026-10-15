using Clash.Ast.Base;
using Clash.Ast.Nodes;
using Clash.Bash;
using Clash.Parser.Implementation;

namespace Clash.Parser;

public class ClashParser
{
    
    public cIAstNode Parse(string command)
    {
        TreeSitter.Tree tree = ParseAndReturnTree(command);

        // cProgram is root node in clash-ast
        cProgramParse programParser = new cProgramParse(command, tree.RootNode);
        cIAstNode rootNode = programParser.Parse(tree.RootNode);
        return rootNode;
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
