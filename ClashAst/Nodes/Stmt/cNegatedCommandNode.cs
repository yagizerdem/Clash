using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Stmt;

public sealed class cNegatedCommandNode : cStmtNode
{
    public cIAstNode Command { get; }

    public cNegatedCommandNode(
        SyntaxInfo syntax,
        cIAstNode command)
        : base(syntax, StatementNodeType.NegatedCommand)
    {
        Command = cStmtNode.Required(command, "command");
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitNegatedCommand<T>(this);
}
