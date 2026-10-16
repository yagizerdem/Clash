using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.PrimaryExpr;

public sealed class cBraceExpressionNode : cPrimaryExprNode
{
    public IReadOnlyList<cIAstNode> Elements { get; }

    public cBraceExpressionNode(
        SyntaxInfo syntax,
        IReadOnlyList<cIAstNode> elements)
        : base(syntax, ExpressionNodeType.BraceExpression)
    {
        Elements = cExprNode.CopyList(elements, "elements");
    }

    public override T Accept<T>(IVisitor<T> visitor) => visitor.VisitBraceExpression(this);
}
