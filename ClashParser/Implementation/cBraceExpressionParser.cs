using Clash.Ast.Base;
using Clash.Ast.Nodes.PrimaryExpr;
using Clash.Parser.Abstract;
using TreeSitter;

namespace Clash.Parser.Implementation;

public class cBraceExpressionParser : ClashBaseParser {

    public cBraceExpressionParser(string program, TreeSitter.Node node) : base(program, node)
    {
    }


    public override cIAstNode Parse(TreeSitter.Node tsNode) {
        this.CheckType(tsNode, "brace_expression");
        SyntaxInfo syntaxInfo = this.ExtractSyntaxInfo();
        List<cIAstNode> parts = this.CollectNamedChildren();
        return new cBraceExpressionNode(syntaxInfo, parts);
    }
}
