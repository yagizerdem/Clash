using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.PrimaryExpr;

public sealed class RawStringNode : PrimaryExprNode
{
    public RawStringNode(SyntaxInfo syntax)
        : base(syntax, ExpressionNodeType.RawString)
    {
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitRawString<T>(this);
}
