using Clash.Ast.Base;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Other;

public sealed class cStringContentNode : cBaseAstNode
{
    public string? Value { get; }

    public cStringContentNode(
        SyntaxInfo syntax,
        string? value)
        : base(syntax)
    {
        Value = value;
    }

    public override T Accept<T>(IVisitor<T> visitor) => visitor.VisitStringContent(this);
}
