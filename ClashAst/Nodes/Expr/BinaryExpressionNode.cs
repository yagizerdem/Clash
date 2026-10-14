using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Expr;

public sealed class BinaryExpressionNode : ExprNode
{
    public IAstNode? Left { get; }
    public string Operator { get; }
    public IReadOnlyList<IAstNode> Right { get; }

    public BinaryExpressionNode(
        SyntaxInfo syntax,
        IAstNode? left,
        string @operator,
        IReadOnlyList<IAstNode> right)
        : base(syntax, ExpressionNodeType.BinaryExpression)
    {
        Left = left;
        Operator = ExprNode.Required(@operator, "operator");
        Right = ExprNode.CopyList(right, "right");
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitBinaryExpression<T>(this);
}
