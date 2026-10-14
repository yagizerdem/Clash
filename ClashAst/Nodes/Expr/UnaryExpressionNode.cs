using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Expr;

public sealed class UnaryExpressionNode : ExprNode
{
    public string Operator { get; }
    public IAstNode Operand { get; }

    public UnaryExpressionNode(
        SyntaxInfo syntax,
        string @operator,
        IAstNode operand)
        : base(syntax, ExpressionNodeType.UnaryExpression)
    {
        Operator = ExprNode.Required(@operator, "operator");
        Operand = ExprNode.Required(operand, "operand");
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitUnaryExpression<T>(this);
}
