using Clash.Ast.Base;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Other;

public sealed class HeredocEndNode : BaseAstNode
{
    public HeredocEndNode(SyntaxInfo syntax)
        : base(syntax)
    {
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitHeredocEnd<T>(this);
}
