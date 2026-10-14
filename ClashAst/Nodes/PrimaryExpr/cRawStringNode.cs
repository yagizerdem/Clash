using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.PrimaryExpr;

public sealed class cRawStringNode : cPrimaryExprNode
{
    public cRawStringNode(SyntaxInfo syntax)
        : base(syntax, ExpressionNodeType.RawString)
    {
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitRawString<T>(this);
}
