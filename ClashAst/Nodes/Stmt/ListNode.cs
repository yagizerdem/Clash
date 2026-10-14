using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Stmt;

public sealed class ListNode : StmtNode
{
    public IReadOnlyList<IAstNode> Statements { get; }
    public IReadOnlyList<ListOperator> Operators { get; }

    public ListNode(
        SyntaxInfo syntax,
        IReadOnlyList<IAstNode> statements,
        IReadOnlyList<ListOperator> operators)
        : base(syntax, StatementNodeType.List)
    {
        Statements = StmtNode.CopyList(statements, "statements");
        Operators = StmtNode.CopyList(operators, "operators");
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitList<T>(this);
}
