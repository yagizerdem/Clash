using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Stmt;

public sealed class NegatedCommandNode : StmtNode
{
    public IAstNode Command { get; }

    public NegatedCommandNode(
        SyntaxInfo syntax,
        IAstNode command)
        : base(syntax, StatementNodeType.NegatedCommand)
    {
        Command = StmtNode.Required(command, "command");
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitNegatedCommand<T>(this);
}
