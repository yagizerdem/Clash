using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Expr;

public sealed class cPostfixExpressionNode : cExprNode
{
    public cIAstNode Operand { get; }
    public string Operator { get; }

    public cPostfixExpressionNode(
        SyntaxInfo syntax,
        cIAstNode operand,
        string @operator)
        : base(syntax, ExpressionNodeType.PostfixExpression)
    {
        Operand = cExprNode.Required(operand, "operand");
        Operator = cExprNode.Required(@operator, "operator");
    }

    public override T Accept<T>(IVisitor<T> visitor) => visitor.VisitPostfixExpression(this);
}
