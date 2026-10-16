using Clash.Ast.Base;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Other;

public sealed class cHeredocEndNode : cBaseAstNode
{
    public cHeredocEndNode(SyntaxInfo syntax)
        : base(syntax)
    {
    }

    public override T Accept<T>(IVisitor<T> visitor) => visitor.VisitHeredocEnd(this);
}
