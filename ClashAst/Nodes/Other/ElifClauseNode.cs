using Clash.Ast.Base;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Other;

public sealed class ElifClauseNode : BaseAstNode
{
    public IReadOnlyList<IAstNode> Condition { get; }
    public IReadOnlyList<IAstNode> ThenBranch { get; }

    public ElifClauseNode(
        SyntaxInfo syntax,
        IReadOnlyList<IAstNode> condition,
        IReadOnlyList<IAstNode> thenBranch)
        : base(syntax)
    {
        Condition = Array.AsReadOnly(condition.ToArray());
        ThenBranch = Array.AsReadOnly(thenBranch.ToArray());
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitElifClause<T>(this);
}
