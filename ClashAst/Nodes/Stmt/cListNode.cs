using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Stmt;

public sealed class cListNode : cStmtNode
{
    public IReadOnlyList<cIAstNode> Statements { get; }
    public IReadOnlyList<ListOperator> Operators { get; }

    public cListNode(
        SyntaxInfo syntax,
        IReadOnlyList<cIAstNode> statements,
        IReadOnlyList<ListOperator> operators)
        : base(syntax, StatementNodeType.List)
    {
        Statements = cStmtNode.CopyList(statements, "statements");
        Operators = cStmtNode.CopyList(operators, "operators");
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitList<T>(this);
}
