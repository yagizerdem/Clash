using Clash.Ast.Base;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Other;

public sealed class cDoGroupNode : cBaseAstNode
{
    public IReadOnlyList<cIAstNode> Statements { get; }

    public cDoGroupNode(
        SyntaxInfo syntax,
        IReadOnlyList<cIAstNode> statements)
        : base(syntax)
    {
        Statements = Array.AsReadOnly(statements.ToArray());
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitDoGroup<T>(this);
}
