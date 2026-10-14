using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Stmt;

public sealed class RedirectedStatementNode : StmtNode
{
    public IAstNode? Body { get; }
    public IReadOnlyList<IAstNode> Redirects { get; }

    public RedirectedStatementNode(
        SyntaxInfo syntax,
        IAstNode? body,
        IReadOnlyList<IAstNode> redirects)
        : base(syntax, StatementNodeType.RedirectedStatement)
    {
        Body = body;
        Redirects = StmtNode.CopyList(redirects, "redirects");
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitRedirectedStatement<T>(this);
}
