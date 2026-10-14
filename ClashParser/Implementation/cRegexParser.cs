using Clash.Ast.Base;
using Clash.Ast.Nodes.Other;
using Clash.Parser.Abstract;
using TreeSitter;

namespace Clash.Parser.Implementation;

public class cRegexParser : ClashBaseParser {

    public cRegexParser(string program, TreeSitter.Node node) : base(program, node)
    {
    }

    public override IAstNode Parse(TreeSitter.Node tsNode) {
        this.CheckType(tsNode, "regex");
        SyntaxInfo syntaxInfo = this.ExtractSyntaxInfo();
        string regex = this.GetProgramByOffsets();

        return new RegexNode(syntaxInfo, regex);
    }
}
