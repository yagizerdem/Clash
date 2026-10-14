using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Expr;

public sealed class ConcatenationNode : ExprNode
{
    public IReadOnlyList<IAstNode> Parts { get; }

    public ConcatenationNode(
        SyntaxInfo syntax,
        IReadOnlyList<IAstNode> parts)
        : base(syntax, ExpressionNodeType.Concatenation)
    {
        Parts = ExprNode.CopyList(parts, "parts");
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitConcatenation<T>(this);
}
