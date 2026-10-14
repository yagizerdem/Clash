using Clash.Ast.Base;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Other;

public sealed class HeredocBodyNode : BaseAstNode
{
    public IReadOnlyList<IAstNode> Parts { get; }

    public HeredocBodyNode(
        SyntaxInfo syntax,
        IReadOnlyList<IAstNode> parts)
        : base(syntax)
    {
        Parts = Array.AsReadOnly(parts.ToArray());
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitHeredocBody<T>(this);
}
