using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.PrimaryExpr;

public sealed class cAnsiCStringNode : cPrimaryExprNode
{
    public cAnsiCStringNode(SyntaxInfo syntax)
        : base(syntax, ExpressionNodeType.AnsiCString)
    {
    }

    public override T Accept<T>(IVisitor<T> visitor) => visitor.VisitAnsiCString(this);
}
