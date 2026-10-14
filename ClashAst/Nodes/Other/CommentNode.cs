using Clash.Ast.Base;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Other;

public sealed class CommentNode : BaseAstNode
{
    public string? Content { get; }

    public CommentNode(
        SyntaxInfo syntax,
        string? content)
        : base(syntax)
    {
        Content = content;
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitComment<T>(this);
}
