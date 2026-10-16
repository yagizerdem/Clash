using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Stmt;

public sealed class cUnsetCommandNode : cStmtNode
{
    public IReadOnlyList<cIAstNode> Targets { get; }

    public cUnsetCommandNode(
        SyntaxInfo syntax,
        IReadOnlyList<cIAstNode> targets)
        : base(syntax, StatementNodeType.UnsetCommand)
    {
        Targets = cStmtNode.CopyList(targets, "targets");
    }

    public override T Accept<T>(IVisitor<T> visitor) => visitor.VisitUnsetCommand(this);
}
