using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Other;

public sealed class HeredocRedirectNode : BaseAstNode
{
    public IAstNode? Descriptor { get; }
    public RedirectionKind RedirectOperator { get; }
    public IReadOnlyList<IAstNode> Arguments { get; }
    public string? Operator { get; }
    public IReadOnlyList<IAstNode> Redirects { get; }
    public StmtNode? Right { get; }
    public IReadOnlyList<IAstNode> Parts { get; }

    public HeredocRedirectNode(
        SyntaxInfo syntax,
        IAstNode? descriptor,
        string redirectOperator,
        IReadOnlyList<IAstNode> arguments,
        string? @operator,
        IReadOnlyList<IAstNode> redirects,
        StmtNode? right,
        IReadOnlyList<IAstNode> parts)
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

    public HeredocRedirectNode(
        SyntaxInfo syntax,
        IAstNode? descriptor,
        RedirectionKind redirectOperator,
        IReadOnlyList<IAstNode> arguments,
        string? @operator,
        IReadOnlyList<IAstNode> redirects,
        StmtNode? right,
        IReadOnlyList<IAstNode> parts)
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

    public override T Accept<T>(IVisitor visitor) => visitor.VisitHeredocRedirect<T>(this);
}
