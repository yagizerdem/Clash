using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.PrimaryExpr;

public sealed class NumberNode : PrimaryExprNode
{
    public IReadOnlyList<IAstNode> Parts { get; }

    public NumberNode(
        SyntaxInfo syntax,
        IReadOnlyList<IAstNode> parts)
        : base(syntax, ExpressionNodeType.Number)
    {
        Parts = ExprNode.CopyList(parts, "parts");
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitNumber<T>(this);
}
