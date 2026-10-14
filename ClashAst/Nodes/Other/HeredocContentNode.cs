using Clash.Ast.Base;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Other;

public sealed class HeredocContentNode : BaseAstNode
{
    public HeredocContentNode(SyntaxInfo syntax)
        : base(syntax)
    {
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitHeredocContent<T>(this);
}
