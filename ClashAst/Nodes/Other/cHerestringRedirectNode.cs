using Clash.Ast.Base;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Other;

public sealed class cHerestringRedirectNode : cBaseAstNode
{
    public cIAstNode? Descriptor { get; }
    public cIAstNode Value { get; }

    public cHerestringRedirectNode(
        SyntaxInfo syntax,
        cIAstNode? descriptor,
        cIAstNode value)
        : base(syntax)
    {
        Descriptor = descriptor;
        Value = value ?? throw new ArgumentNullException("value");
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitHerestringRedirect<T>(this);
}
