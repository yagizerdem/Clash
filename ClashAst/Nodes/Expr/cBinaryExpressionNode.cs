using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Expr;

public sealed class cBinaryExpressionNode : cExprNode
{
    public cIAstNode? Left { get; }
    public string Operator { get; }
    public IReadOnlyList<cIAstNode> Right { get; }

    public cBinaryExpressionNode(
        SyntaxInfo syntax,
        cIAstNode? left,
        string @operator,
        IReadOnlyList<cIAstNode> right)
        : base(syntax, ExpressionNodeType.BinaryExpression)
    {
        Left = left;
        Operator = cExprNode.Required(@operator, "operator");
        Right = cExprNode.CopyList(right, "right");
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitBinaryExpression<T>(this);
}
