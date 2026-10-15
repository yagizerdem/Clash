using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Expr;

public sealed class cTernaryExpressionNode : cExprNode
{
    public cIAstNode Condition { get; }
    public cIAstNode Consequence { get; }
    public cIAstNode Alternative { get; }

    public cTernaryExpressionNode(
        SyntaxInfo syntax,
        cIAstNode condition,
        cIAstNode consequence,
        cIAstNode alternative)
        : base(syntax, ExpressionNodeType.TernaryExpression)
    {
        Condition = cExprNode.Required(condition, "condition");
        Consequence = cExprNode.Required(consequence, "consequence");
        Alternative = cExprNode.Required(alternative, "alternative");
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitTernaryExpression<T>(this);
}
