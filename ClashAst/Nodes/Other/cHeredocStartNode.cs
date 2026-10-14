using Clash.Ast.Base;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Other;

public sealed class cHeredocStartNode : cBaseAstNode
{
    public cHeredocStartNode(SyntaxInfo syntax)
        : base(syntax)
    {
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitHeredocStart<T>(this);
}
