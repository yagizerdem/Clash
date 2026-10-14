using Clash.Ast.Base;
using Clash.Ast.Nodes.PrimaryExpr;
using Clash.Parser.Abstract;
using TreeSitter;

namespace Clash.Parser.Implementation;

public class cStringParser : ClashBaseParser {

    public cStringParser(string program, TreeSitter.Node node) : base(program, node)
    {
    }

    public override cIAstNode Parse(TreeSitter.Node tsNode) {
        this.CheckType(tsNode, "string");
        SyntaxInfo syntaxInfo = this.ExtractSyntaxInfo();
        List<cIAstNode> parts = this.CollectNamedChildren(tsNode);
        return new cStringNode(syntaxInfo, parts);
    }
}
