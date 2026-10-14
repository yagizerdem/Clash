using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Expr;

public sealed class PostfixExpressionNode : ExprNode
{
    public IAstNode Operand { get; }
    public string Operator { get; }

    public PostfixExpressionNode(
        SyntaxInfo syntax,
        IAstNode operand,
        string @operator)
        : base(syntax, ExpressionNodeType.PostfixExpression)
    {
        Operand = ExprNode.Required(operand, "operand");
        Operator = ExprNode.Required(@operator, "operator");
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitPostfixExpression<T>(this);
}
