using Clash.Ast.Base;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Other;

public sealed class SubscriptNode : BaseAstNode
{
    public IAstNode Name { get; }
    public IAstNode Index { get; }
    public IReadOnlyList<IAstNode> Suffix { get; }

    public SubscriptNode(
        SyntaxInfo syntax,
        IAstNode name,
        IAstNode index,
        IReadOnlyList<IAstNode> suffix)
        : base(syntax)
    {
        Name = name ?? throw new ArgumentNullException("name");
        Index = index ?? throw new ArgumentNullException("index");
        Suffix = Array.AsReadOnly(suffix.ToArray());
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitSubscript<T>(this);
}
