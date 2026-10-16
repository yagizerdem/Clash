using Clash.Ast.Base;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Other;

public sealed class cHeredocBodyNode : cBaseAstNode
{
    public IReadOnlyList<cIAstNode> Parts { get; }

    public cHeredocBodyNode(
        SyntaxInfo syntax,
        IReadOnlyList<cIAstNode> parts)
        : base(syntax)
    {
        Parts = Array.AsReadOnly(parts.ToArray());
    }

    public override T Accept<T>(IVisitor<T> visitor) => visitor.VisitHeredocBody(this);
}
