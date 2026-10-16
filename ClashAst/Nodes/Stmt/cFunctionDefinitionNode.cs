using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Stmt;

public sealed class cFunctionDefinitionNode : cStmtNode
{
    public cIAstNode Name { get; }
    public cIAstNode Body { get; }
    public IReadOnlyList<cIAstNode> Redirects { get; }

    public cFunctionDefinitionNode(
        SyntaxInfo syntax,
        cIAstNode name,
        cIAstNode body,
        IReadOnlyList<cIAstNode> redirects)
        : base(syntax, StatementNodeType.FunctionDefinition)
    {
        Name = cStmtNode.Required(name, "name");
        Body = cStmtNode.Required(body, "body");
        Redirects = cStmtNode.CopyList(redirects, "redirects");
    }

    public override T Accept<T>(IVisitor<T> visitor) => visitor.VisitFunctionDefinition(this);
}
