using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Stmt;

public sealed class IfStatementNode : StmtNode
{
    public IReadOnlyList<IAstNode> Condition { get; }
    public IReadOnlyList<IAstNode> ThenBranch { get; }
    public IReadOnlyList<IAstNode> ElifClauses { get; }
    public IAstNode? ElseClause { get; }

    public IfStatementNode(
        SyntaxInfo syntax,
        IReadOnlyList<IAstNode> condition,
        IReadOnlyList<IAstNode> thenBranch,
        IReadOnlyList<IAstNode> elifClauses,
        IAstNode? elseClause)
        : base(syntax, StatementNodeType.IfStatement)
    {
        Condition = StmtNode.CopyList(condition, "condition");
        ThenBranch = StmtNode.CopyList(thenBranch, "thenBranch");
        ElifClauses = StmtNode.CopyList(elifClauses, "elifClauses");
        ElseClause = elseClause;
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitIfStatement<T>(this);
}
