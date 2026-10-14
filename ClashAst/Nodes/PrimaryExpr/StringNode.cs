using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.PrimaryExpr;

public sealed class StringNode : PrimaryExprNode
{
    public IReadOnlyList<IAstNode> Parts { get; }

    public StringNode(
        SyntaxInfo syntax,
        IReadOnlyList<IAstNode> parts)
        : base(syntax, ExpressionNodeType.String)
    {
        Parts = ExprNode.CopyList(parts, "parts");
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitString<T>(this);
}
