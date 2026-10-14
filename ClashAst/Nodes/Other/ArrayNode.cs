using Clash.Ast.Base;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Other;

public sealed class ArrayNode : BaseAstNode
{
    public IReadOnlyList<IAstNode> Elements { get; }

    public ArrayNode(
        SyntaxInfo syntax,
        IReadOnlyList<IAstNode> elements)
        : base(syntax)
    {
        Elements = Array.AsReadOnly(elements.ToArray());
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitArray<T>(this);
}
