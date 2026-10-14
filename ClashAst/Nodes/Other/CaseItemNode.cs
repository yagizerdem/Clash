using Clash.Ast.Base;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Other;

public sealed class CaseItemNode : BaseAstNode
{
    public IReadOnlyList<IAstNode> Values { get; }
    public IReadOnlyList<IAstNode> Statements { get; }
    public string? Terminator { get; }

    public CaseItemNode(
        SyntaxInfo syntax,
        IReadOnlyList<IAstNode> values,
        IReadOnlyList<IAstNode> statements,
        string? terminator)
        : base(syntax)
    {
        Values = Array.AsReadOnly(values.ToArray());
        Statements = Array.AsReadOnly(statements.ToArray());
        Terminator = terminator;
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitCaseItem<T>(this);
}
