using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Expr;

public sealed class TernaryExpressionNode : ExprNode
{
    public IAstNode Condition { get; }
    public IAstNode Consequence { get; }
    public IAstNode Alternative { get; }

    public TernaryExpressionNode(
        SyntaxInfo syntax,
        IAstNode condition,
        IAstNode consequence,
        IAstNode alternative)
        : base(syntax, ExpressionNodeType.TernaryExpression)
    {
        Condition = ExprNode.Required(condition, "condition");
        Consequence = ExprNode.Required(consequence, "consequence");
        Alternative = ExprNode.Required(alternative, "alternative");
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitTernaryExpression<T>(this);
}
