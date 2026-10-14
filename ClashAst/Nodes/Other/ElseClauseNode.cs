using Clash.Ast.Base;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Other;

public sealed class ElseClauseNode : BaseAstNode
{
    public IReadOnlyList<IAstNode> Statements { get; }

    public ElseClauseNode(
        SyntaxInfo syntax,
        IReadOnlyList<IAstNode> statements)
        : base(syntax)
    {
        Statements = Array.AsReadOnly(statements.ToArray());
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitElseClause<T>(this);
}
