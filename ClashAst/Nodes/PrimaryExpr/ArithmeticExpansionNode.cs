using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.PrimaryExpr;

public sealed class ArithmeticExpansionNode : PrimaryExprNode
{
    public IReadOnlyList<IAstNode> Expressions { get; }

    public ArithmeticExpansionNode(
        SyntaxInfo syntax,
        IReadOnlyList<IAstNode> expressions)
        : base(syntax, ExpressionNodeType.ArithmeticExpansion)
    {
        Expressions = ExprNode.CopyList(expressions, "expressions");
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitArithmeticExpansion<T>(this);
}
