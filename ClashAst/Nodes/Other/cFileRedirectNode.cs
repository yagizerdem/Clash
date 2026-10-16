using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Other;

public sealed class cFileRedirectNode : cBaseAstNode
{
    public cIAstNode? Descriptor { get; }
    public RedirectionKind Operator { get; }
    public IReadOnlyList<cIAstNode> Destinations { get; }

    public cFileRedirectNode(
        SyntaxInfo syntax,
        cIAstNode? descriptor,
        RedirectionKind redirectionKind,
        IReadOnlyList<cIAstNode> destinations)
        : base(syntax)
    {
        Descriptor = descriptor;
        Operator = redirectionKind;
        Destinations = Array.AsReadOnly(destinations.ToArray());
    }

    public cFileRedirectNode(
        SyntaxInfo syntax,
        cIAstNode? descriptor,
        string @operator,
        IReadOnlyList<cIAstNode> destinations)
        : base(syntax)
    {
        Descriptor = descriptor;
        Operator = RedirectionKindExtensions.FromSymbol(@operator ?? throw new ArgumentNullException("operator"));
        Destinations = Array.AsReadOnly(destinations.ToArray());
    }

    public override T Accept<T>(IVisitor<T> visitor) => visitor.VisitFileRedirect(this);
}
