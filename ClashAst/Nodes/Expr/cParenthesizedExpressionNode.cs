using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Expr;

public sealed class cParenthesizedExpressionNode : cExprNode
{
    public cIAstNode Expression { get; }

    public cParenthesizedExpressionNode(
        SyntaxInfo syntax,
        cIAstNode expression)
        : base(syntax, ExpressionNodeType.ParenthesizedExpression)
    {
        Expression = cExprNode.Required(expression, "expression");
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitParenthesizedExpression<T>(this);
}
