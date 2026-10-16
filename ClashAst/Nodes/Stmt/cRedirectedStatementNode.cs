using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Stmt;

public sealed class cRedirectedStatementNode : cStmtNode
{
    public cIAstNode? Body { get; }
    public IReadOnlyList<cIAstNode> Redirects { get; }

    public cRedirectedStatementNode(
        SyntaxInfo syntax,
        cIAstNode? body,
        IReadOnlyList<cIAstNode> redirects)
        : base(syntax, StatementNodeType.RedirectedStatement)
    {
        Body = body;
        Redirects = cStmtNode.CopyList(redirects, "redirects");
    }

    public override T Accept<T>(IVisitor<T> visitor) => visitor.VisitRedirectedStatement(this);
}
