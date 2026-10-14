using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Stmt;

public sealed class cWhileStatementNode : cStmtNode
{
    public LoopKind LoopKind { get; }
    public IReadOnlyList<cIAstNode> Condition { get; }
    public cIAstNode Body { get; }

    public cWhileStatementNode(
        SyntaxInfo syntax,
        LoopKind loopKind,
        IReadOnlyList<cIAstNode> condition,
        cIAstNode body)
        : base(syntax, StatementNodeType.WhileStatement)
    {
        LoopKind = cStmtNode.Required(loopKind, "loopKind");
        Condition = cStmtNode.CopyList(condition, "condition");
        Body = cStmtNode.Required(body, "body");
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitWhileStatement<T>(this);
}
