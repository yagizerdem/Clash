using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Stmt;

public sealed class SubshellNode : StmtNode
{
    public IReadOnlyList<IAstNode> Statements { get; }

    public SubshellNode(
        SyntaxInfo syntax,
        IReadOnlyList<IAstNode> statements)
        : base(syntax, StatementNodeType.Subshell)
    {
        Statements = StmtNode.CopyList(statements, "statements");
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitSubshell<T>(this);
}
