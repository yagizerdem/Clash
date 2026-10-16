using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Stmt;

public sealed class cCommandNode : cStmtNode
{
    public cIAstNode Name { get; }
    public IReadOnlyList<cIAstNode> Arguments { get; }
    public IReadOnlyList<cIAstNode> Redirects { get; }
    public IReadOnlyList<cIAstNode> Prefixes { get; }

    public cCommandNode(
        SyntaxInfo syntax,
        cIAstNode name,
        IReadOnlyList<cIAstNode> arguments,
        IReadOnlyList<cIAstNode> redirects,
        IReadOnlyList<cIAstNode> prefixes)
        : base(syntax, StatementNodeType.Command)
    {
        Name = cStmtNode.Required(name, "name");
        Arguments = cStmtNode.CopyList(arguments, "arguments");
        Redirects = cStmtNode.CopyList(redirects, "redirects");
        Prefixes = cStmtNode.CopyList(prefixes, "prefixes");
    }

    public override T Accept<T>(IVisitor<T> visitor) => visitor.VisitCommand(this);
}
