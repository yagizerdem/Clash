using Clash.Ast.Base;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Other;

public sealed class StringContentNode : BaseAstNode
{
    public string? Value { get; }

    public StringContentNode(
        SyntaxInfo syntax,
        string? value)
        : base(syntax)
    {
        Value = value;
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitStringContent<T>(this);
}
