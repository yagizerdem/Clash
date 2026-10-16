using Clash.Ast.Base;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Other;

public sealed class cElseClauseNode : cBaseAstNode
{
    public IReadOnlyList<cIAstNode> Statements { get; }

    public cElseClauseNode(
        SyntaxInfo syntax,
        IReadOnlyList<cIAstNode> statements)
        : base(syntax)
    {
        Statements = Array.AsReadOnly(statements.ToArray());
    }

    public override T Accept<T>(IVisitor<T> visitor) => visitor.VisitElseClause(this);
}
