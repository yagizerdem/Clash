using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Expr;

public sealed class cUnaryExpressionNode : cExprNode
{
    public string Operator { get; }
    public cIAstNode Operand { get; }

    public cUnaryExpressionNode(
        SyntaxInfo syntax,
        string @operator,
        cIAstNode operand)
        : base(syntax, ExpressionNodeType.UnaryExpression)
    {
        Operator = cExprNode.Required(@operator, "operator");
        Operand = cExprNode.Required(operand, "operand");
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitUnaryExpression<T>(this);
}
