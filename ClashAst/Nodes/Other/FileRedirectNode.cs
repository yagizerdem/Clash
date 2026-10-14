using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Other;

public sealed class FileRedirectNode : BaseAstNode
{
    public IAstNode? Descriptor { get; }
    public RedirectionKind Operator { get; }
    public IReadOnlyList<IAstNode> Destinations { get; }

    public FileRedirectNode(
        SyntaxInfo syntax,
        IAstNode? descriptor,
        RedirectionKind redirectionKind,
        IReadOnlyList<IAstNode> destinations)
        : base(syntax)
    {
        Descriptor = descriptor;
        Operator = redirectionKind;
        Destinations = Array.AsReadOnly(destinations.ToArray());
    }

    public FileRedirectNode(
        SyntaxInfo syntax,
        IAstNode? descriptor,
        string @operator,
        IReadOnlyList<IAstNode> destinations)
        : base(syntax)
    {
        Descriptor = descriptor;
        Operator = RedirectionKindExtensions.FromSymbol(@operator ?? throw new ArgumentNullException("operator"));
        Destinations = Array.AsReadOnly(destinations.ToArray());
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitFileRedirect<T>(this);
}
