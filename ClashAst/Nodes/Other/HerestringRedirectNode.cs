using Clash.Ast.Base;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Other;

public sealed class HerestringRedirectNode : BaseAstNode
{
    public IAstNode? Descriptor { get; }
    public IAstNode Value { get; }

    public HerestringRedirectNode(
        SyntaxInfo syntax,
        IAstNode? descriptor,
        IAstNode value)
        : base(syntax)
    {
        Descriptor = descriptor;
        Value = value ?? throw new ArgumentNullException("value");
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitHerestringRedirect<T>(this);
}
