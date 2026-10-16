using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Other;

public sealed class cHeredocRedirectNode : cBaseAstNode
{
    public cIAstNode? Descriptor { get; }
    public RedirectionKind RedirectOperator { get; }
    public IReadOnlyList<cIAstNode> Arguments { get; }
    public string? Operator { get; }
    public IReadOnlyList<cIAstNode> Redirects { get; }
    public cStmtNode? Right { get; }
    public IReadOnlyList<cIAstNode> Parts { get; }

    public cHeredocRedirectNode(
        SyntaxInfo syntax,
        cIAstNode? descriptor,
        string redirectOperator,
        IReadOnlyList<cIAstNode> arguments,
        string? @operator,
        IReadOnlyList<cIAstNode> redirects,
        cStmtNode? right,
        IReadOnlyList<cIAstNode> parts)
        : base(syntax)
    {
        Descriptor = descriptor;
        RedirectOperator = RedirectionKindExtensions.FromSymbol(redirectOperator);
        Arguments = Array.AsReadOnly(arguments.ToArray());
        Operator = @operator;
        Redirects = Array.AsReadOnly(redirects.ToArray());
        Right = right;
        Parts = Array.AsReadOnly(parts.ToArray());
    }

    public cHeredocRedirectNode(
        SyntaxInfo syntax,
        cIAstNode? descriptor,
        RedirectionKind redirectOperator,
        IReadOnlyList<cIAstNode> arguments,
        string? @operator,
        IReadOnlyList<cIAstNode> redirects,
        cStmtNode? right,
        IReadOnlyList<cIAstNode> parts)
        : base(syntax)
    {
        Descriptor = descriptor;
        RedirectOperator = redirectOperator;
        Arguments = Array.AsReadOnly(arguments.ToArray());
        Operator = @operator;
        Redirects = Array.AsReadOnly(redirects.ToArray());
        Right = right;
        Parts = Array.AsReadOnly(parts.ToArray());
    }

    public override T Accept<T>(IVisitor<T> visitor) => visitor.VisitHeredocRedirect(this);
}
