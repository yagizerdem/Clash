using Clash.Ast.Base;
using Clash.Ast.Nodes.Other;
using Clash.Parser.Abstract;
using TreeSitter;

namespace Clash.Parser.Implementation;

public class cExtglobPatternParser : ClashBaseParser {
    public cExtglobPatternParser(string program, TreeSitter.Node node) : base(program, node)
    {
    }

    public override cIAstNode Parse(TreeSitter.Node tsNode) {
        this.CheckType(tsNode, "extglob_pattern");
        return new cExtglobPatternNode(this.ExtractSyntaxInfo());
    }
}
