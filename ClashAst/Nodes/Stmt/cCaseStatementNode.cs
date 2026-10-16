using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Stmt;

public sealed class cCaseStatementNode : cStmtNode
{
    public cIAstNode Value { get; }
    public IReadOnlyList<cIAstNode> Items { get; }

    public cCaseStatementNode(
        SyntaxInfo syntax,
        cIAstNode value,
        IReadOnlyList<cIAstNode> items)
        : base(syntax, StatementNodeType.CaseStatement)
    {
        Value = cStmtNode.Required(value, "value");
        Items = cStmtNode.CopyList(items, "items");
    }

    public override T Accept<T>(IVisitor<T> visitor) => visitor.VisitCaseStatement(this);
}
