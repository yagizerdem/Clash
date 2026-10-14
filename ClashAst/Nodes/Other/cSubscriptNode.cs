using Clash.Ast.Base;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Other;

public sealed class cSubscriptNode : cBaseAstNode
{
    public cIAstNode Name { get; }
    public cIAstNode Index { get; }
    public IReadOnlyList<cIAstNode> Suffix { get; }

    public cSubscriptNode(
        SyntaxInfo syntax,
        cIAstNode name,
        cIAstNode index,
        IReadOnlyList<cIAstNode> suffix)
        : base(syntax)
    {
        Name = name ?? throw new ArgumentNullException("name");
        Index = index ?? throw new ArgumentNullException("index");
        Suffix = Array.AsReadOnly(suffix.ToArray());
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitSubscript<T>(this);
}
