using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.PrimaryExpr;

public sealed class cStringNode : cPrimaryExprNode
{
    public IReadOnlyList<cIAstNode> Parts { get; }

    public cStringNode(
        SyntaxInfo syntax,
        IReadOnlyList<cIAstNode> parts)
        : base(syntax, ExpressionNodeType.String)
    {
        Parts = cExprNode.CopyList(parts, "parts");
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitString<T>(this);
}
