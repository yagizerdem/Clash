using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Stmt;

public sealed class cIfStatementNode : cStmtNode
{
    public IReadOnlyList<cIAstNode> Condition { get; }
    public IReadOnlyList<cIAstNode> ThenBranch { get; }
    public IReadOnlyList<cIAstNode> ElifClauses { get; }
    public cIAstNode? ElseClause { get; }

    public cIfStatementNode(
        SyntaxInfo syntax,
        IReadOnlyList<cIAstNode> condition,
        IReadOnlyList<cIAstNode> thenBranch,
        IReadOnlyList<cIAstNode> elifClauses,
        cIAstNode? elseClause)
        : base(syntax, StatementNodeType.IfStatement)
    {
        Condition = cStmtNode.CopyList(condition, "condition");
        ThenBranch = cStmtNode.CopyList(thenBranch, "thenBranch");
        ElifClauses = cStmtNode.CopyList(elifClauses, "elifClauses");
        ElseClause = elseClause;
    }

    public override T Accept<T>(IVisitor<T> visitor) => visitor.VisitIfStatement(this);
}
