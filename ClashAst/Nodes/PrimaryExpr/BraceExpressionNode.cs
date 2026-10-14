using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.PrimaryExpr;

public sealed class BraceExpressionNode : PrimaryExprNode
{
    public IReadOnlyList<IAstNode> Elements { get; }

    public BraceExpressionNode(
        SyntaxInfo syntax,
        IReadOnlyList<IAstNode> elements)
        : base(syntax, ExpressionNodeType.BraceExpression)
    {
        Elements = ExprNode.CopyList(elements, "elements");
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitBraceExpression<T>(this);
}
