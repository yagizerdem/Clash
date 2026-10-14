using Clash.Ast.Base;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Other;

public sealed class cCommentNode : cBaseAstNode
{
    public string? Content { get; }

    public cCommentNode(
        SyntaxInfo syntax,
        string? content)
        : base(syntax)
    {
        Content = content;
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitComment<T>(this);
}
