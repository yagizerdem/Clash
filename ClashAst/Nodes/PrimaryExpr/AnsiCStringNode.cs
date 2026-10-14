using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.PrimaryExpr;

public sealed class AnsiCStringNode : PrimaryExprNode
{
    public AnsiCStringNode(SyntaxInfo syntax)
        : base(syntax, ExpressionNodeType.AnsiCString)
    {
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitAnsiCString<T>(this);
}
