using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Expr;

public sealed class ParenthesizedExpressionNode : ExprNode
{
    public IAstNode Expression { get; }

    public ParenthesizedExpressionNode(
        SyntaxInfo syntax,
        IAstNode expression)
        : base(syntax, ExpressionNodeType.ParenthesizedExpression)
    {
        Expression = ExprNode.Required(expression, "expression");
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitParenthesizedExpression<T>(this);
}
