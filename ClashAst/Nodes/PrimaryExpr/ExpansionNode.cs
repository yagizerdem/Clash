using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.PrimaryExpr;

public sealed class ExpansionNode : PrimaryExprNode
{
    public IReadOnlyList<String>? Operator { get; }
    public IReadOnlyList<IAstNode> Parts { get; }

    public ExpansionNode(
        SyntaxInfo syntax,
        IReadOnlyList<String>? @operator,
        IReadOnlyList<IAstNode> parts)
        : base(syntax, ExpressionNodeType.Expansion)
    {
        Operator = @operator;
        Parts = ExprNode.CopyList(parts, "parts");
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitExpansion<T>(this);
}
