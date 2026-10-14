using Clash.Ast.Base;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Other;

public sealed class CommandNameNode : BaseAstNode
{
    public IAstNode Value { get; }

    public CommandNameNode(
        SyntaxInfo syntax,
        IAstNode value)
        : base(syntax)
    {
        Value = value ?? throw new ArgumentNullException("value");
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitCommandName<T>(this);
}
