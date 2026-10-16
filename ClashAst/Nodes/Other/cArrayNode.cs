using Clash.Ast.Base;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Other;

public sealed class cArrayNode : cBaseAstNode
{
    public IReadOnlyList<cIAstNode> Elements { get; }

    public cArrayNode(
        SyntaxInfo syntax,
        IReadOnlyList<cIAstNode> elements)
        : base(syntax)
    {
        Elements = Array.AsReadOnly(elements.ToArray());
    }

    public override T Accept<T>(IVisitor<T> visitor) => visitor.VisitArray(this);
}
