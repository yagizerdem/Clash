using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.PrimaryExpr;

public sealed class cNumberNode : cPrimaryExprNode
{
    public IReadOnlyList<cIAstNode> Parts { get; }

    public cNumberNode(
        SyntaxInfo syntax,
        IReadOnlyList<cIAstNode> parts)
        : base(syntax, ExpressionNodeType.Number)
    {
        Parts = cExprNode.CopyList(parts, "parts");
    }

    public override T Accept<T>(IVisitor<T> visitor) => visitor.VisitNumber(this);
}
