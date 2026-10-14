using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Stmt;

public sealed class CStyleForStatementNode : StmtNode
{
    public IReadOnlyList<IAstNode> Initializer { get; }
    public IReadOnlyList<IAstNode> Condition { get; }
    public IReadOnlyList<IAstNode> Update { get; }
    public IAstNode Body { get; }

    public CStyleForStatementNode(
        SyntaxInfo syntax,
        IReadOnlyList<IAstNode> initializer,
        IReadOnlyList<IAstNode> condition,
        IReadOnlyList<IAstNode> update,
        IAstNode body)
        : base(syntax, StatementNodeType.CStyleForStatement)
    {
        Initializer = StmtNode.CopyList(initializer, "initializer");
        Condition = StmtNode.CopyList(condition, "condition");
        Update = StmtNode.CopyList(update, "update");
        Body = StmtNode.Required(body, "body");
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitCStyleForStatement<T>(this);
}
