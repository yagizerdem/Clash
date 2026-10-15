using Clash.Ast.Base;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Other;

public sealed class cCaseItemNode : cBaseAstNode
{
    public IReadOnlyList<cIAstNode> Values { get; }
    public IReadOnlyList<cIAstNode> Statements { get; }
    public string? Terminator { get; }

    public cCaseItemNode(
        SyntaxInfo syntax,
        IReadOnlyList<cIAstNode> values,
        IReadOnlyList<cIAstNode> statements,
        string? terminator)
        : base(syntax)
    {
        Values = Array.AsReadOnly(values.ToArray());
        Statements = Array.AsReadOnly(statements.ToArray());
        Terminator = terminator;
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitCaseItem<T>(this);
}
