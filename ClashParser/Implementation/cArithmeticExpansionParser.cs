using Clash.Ast.Base;
using Clash.Ast.Nodes.PrimaryExpr;
using Clash.Parser.Abstract;
using TreeSitter;

namespace Clash.Parser.Implementation;

public class cArithmeticExpansionParser : ClashBaseParser {

    public cArithmeticExpansionParser(string program, TreeSitter.Node node) : base(program, node)
    {
    }

    public override IAstNode Parse(TreeSitter.Node tsNode) {
        this.CheckType(tsNode, "arithmetic_expansion");
        SyntaxInfo syntaxInfo = this.ExtractSyntaxInfo();
        List<IAstNode> parts = this.CollectNamedChildren(tsNode);
        return new ArithmeticExpansionNode(syntaxInfo, parts);
    }
}
