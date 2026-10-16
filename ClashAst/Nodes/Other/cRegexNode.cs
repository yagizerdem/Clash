using Clash.Ast.Base;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Other;

public class cRegexNode : cBaseAstNode
{
    public string? Regex { get; }

    public cRegexNode(
        SyntaxInfo syntax,
        string? regex)
        : base(syntax)
    {
        Regex = regex;
    }

    public override T Accept<T>(IVisitor<T> visitor) => visitor.VisitRegex(this);
}
