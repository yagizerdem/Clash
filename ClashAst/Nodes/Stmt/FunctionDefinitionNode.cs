using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Stmt;

public sealed class FunctionDefinitionNode : StmtNode
{
    public IAstNode Name { get; }
    public IAstNode Body { get; }
    public IReadOnlyList<IAstNode> Redirects { get; }

    public FunctionDefinitionNode(
        SyntaxInfo syntax,
        IAstNode name,
        IAstNode body,
        IReadOnlyList<IAstNode> redirects)
        : base(syntax, StatementNodeType.FunctionDefinition)
    {
        Name = StmtNode.Required(name, "name");
        Body = StmtNode.Required(body, "body");
        Redirects = StmtNode.CopyList(redirects, "redirects");
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitFunctionDefinition<T>(this);
}
