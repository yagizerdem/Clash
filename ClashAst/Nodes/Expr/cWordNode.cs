using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Expr;

public sealed class cWordNode : cPrimaryExprNode
{
    public cWordNode(SyntaxInfo syntax)
        : base(syntax, ExpressionNodeType.Word)
    {
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitWord<T>(this);
}
