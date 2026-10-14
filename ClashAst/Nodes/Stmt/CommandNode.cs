using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Stmt;

public sealed class CommandNode : StmtNode
{
    public IAstNode Name { get; }
    public IReadOnlyList<IAstNode> Arguments { get; }
    public IReadOnlyList<IAstNode> Redirects { get; }
    public IReadOnlyList<IAstNode> Prefixes { get; }

    public CommandNode(
        SyntaxInfo syntax,
        IAstNode name,
        IReadOnlyList<IAstNode> arguments,
        IReadOnlyList<IAstNode> redirects,
        IReadOnlyList<IAstNode> prefixes)
        : base(syntax, StatementNodeType.Command)
    {
        Name = StmtNode.Required(name, "name");
        Arguments = StmtNode.CopyList(arguments, "arguments");
        Redirects = StmtNode.CopyList(redirects, "redirects");
        Prefixes = StmtNode.CopyList(prefixes, "prefixes");
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitCommand<T>(this);
}
