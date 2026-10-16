using Clash.Ast.Base;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Other;

public sealed class cCommandNameNode : cBaseAstNode
{
    public cIAstNode Value { get; }

    public cCommandNameNode(
        SyntaxInfo syntax,
        cIAstNode value)
        : base(syntax)
    {
        Value = value ?? throw new ArgumentNullException("value");
    }

    public override T Accept<T>(IVisitor<T> visitor) => visitor.VisitCommandName(this);
}
