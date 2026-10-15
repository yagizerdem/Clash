using Clash.Ast.Base;
using Clash.Ast.Nodes.Expr;
using Clash.Parser.Abstract;
using TreeSitter;

namespace Clash.Parser.Implementation;

public class cParenthesizedExpressionParser : ClashBaseParser {

    public cParenthesizedExpressionParser(string program, TreeSitter.Node node) : base(program, node)
    {
    }

    public override cIAstNode Parse(TreeSitter.Node tsNode) {
        this.CheckType(tsNode, "parenthesized_expression");
        SyntaxInfo syntaxInfo = this.ExtractSyntaxInfo();
        TreeSitter.Node tsExpression = tsNode.NamedChildren[0];
        cIAstNode expression = this.Dispatcher(tsExpression).Parse(tsExpression);
        return new cParenthesizedExpressionNode(syntaxInfo, expression);
    }
}
