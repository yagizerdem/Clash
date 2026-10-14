using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Stmt;

public sealed class WhileStatementNode : StmtNode
{
    public LoopKind LoopKind { get; }
    public IReadOnlyList<IAstNode> Condition { get; }
    public IAstNode Body { get; }

    public WhileStatementNode(
        SyntaxInfo syntax,
        LoopKind loopKind,
        IReadOnlyList<IAstNode> condition,
        IAstNode body)
        : base(syntax, StatementNodeType.WhileStatement)
    {
        LoopKind = StmtNode.Required(loopKind, "loopKind");
        Condition = StmtNode.CopyList(condition, "condition");
        Body = StmtNode.Required(body, "body");
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitWhileStatement<T>(this);
}
