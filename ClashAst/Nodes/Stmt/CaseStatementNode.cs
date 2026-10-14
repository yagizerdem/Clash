using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Stmt;

public sealed class CaseStatementNode : StmtNode
{
    public IAstNode Value { get; }
    public IReadOnlyList<IAstNode> Items { get; }

    public CaseStatementNode(
        SyntaxInfo syntax,
        IAstNode value,
        IReadOnlyList<IAstNode> items)
        : base(syntax, StatementNodeType.CaseStatement)
    {
        Value = StmtNode.Required(value, "value");
        Items = StmtNode.CopyList(items, "items");
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitCaseStatement<T>(this);
}
