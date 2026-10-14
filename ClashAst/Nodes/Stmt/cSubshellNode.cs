using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Stmt;

public sealed class cSubshellNode : cStmtNode
{
    public IReadOnlyList<cIAstNode> Statements { get; }

    public cSubshellNode(
        SyntaxInfo syntax,
        IReadOnlyList<cIAstNode> statements)
        : base(syntax, StatementNodeType.Subshell)
    {
        Statements = cStmtNode.CopyList(statements, "statements");
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitSubshell<T>(this);
}
