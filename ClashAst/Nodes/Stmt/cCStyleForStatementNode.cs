using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Stmt;

public sealed class cCStyleForStatementNode : cStmtNode
{
    public IReadOnlyList<cIAstNode> Initializer { get; }
    public IReadOnlyList<cIAstNode> Condition { get; }
    public IReadOnlyList<cIAstNode> Update { get; }
    public cIAstNode Body { get; }

    public cCStyleForStatementNode(
        SyntaxInfo syntax,
        IReadOnlyList<cIAstNode> initializer,
        IReadOnlyList<cIAstNode> condition,
        IReadOnlyList<cIAstNode> update,
        cIAstNode body)
        : base(syntax, StatementNodeType.CStyleForStatement)
    {
        Initializer = cStmtNode.CopyList(initializer, "initializer");
        Condition = cStmtNode.CopyList(condition, "condition");
        Update = cStmtNode.CopyList(update, "update");
        Body = cStmtNode.Required(body, "body");
    }

    public override T Accept<T>(IVisitor<T> visitor) => visitor.VisitCStyleForStatement(this);
}
