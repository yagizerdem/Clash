using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Stmt;

public sealed class UnsetCommandNode : StmtNode
{
    public IReadOnlyList<IAstNode> Targets { get; }

    public UnsetCommandNode(
        SyntaxInfo syntax,
        IReadOnlyList<IAstNode> targets)
        : base(syntax, StatementNodeType.UnsetCommand)
    {
        Targets = StmtNode.CopyList(targets, "targets");
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitUnsetCommand<T>(this);
}
