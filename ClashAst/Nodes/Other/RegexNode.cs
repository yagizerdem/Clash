using Clash.Ast.Base;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Other;

public class RegexNode : BaseAstNode
{
    public string? Regex { get; }

    public RegexNode(
        SyntaxInfo syntax,
        string? regex)
        : base(syntax)
    {
        Regex = regex;
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitRegex<T>(this);
}
