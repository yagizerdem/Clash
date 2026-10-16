using Clash.Ast.Base;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Other;

public sealed class cElifClauseNode : cBaseAstNode
{
    public IReadOnlyList<cIAstNode> Condition { get; }
    public IReadOnlyList<cIAstNode> ThenBranch { get; }

    public cElifClauseNode(
        SyntaxInfo syntax,
        IReadOnlyList<cIAstNode> condition,
        IReadOnlyList<cIAstNode> thenBranch)
        : base(syntax)
    {
        Condition = Array.AsReadOnly(condition.ToArray());
        ThenBranch = Array.AsReadOnly(thenBranch.ToArray());
    }

    public override T Accept<T>(IVisitor<T> visitor) => visitor.VisitElifClause(this);
}
