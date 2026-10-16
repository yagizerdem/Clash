using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.PrimaryExpr;

public sealed class cExpansionNode : cPrimaryExprNode
{
    public IReadOnlyList<String>? Operator { get; }
    public IReadOnlyList<cIAstNode> Parts { get; }

    public cExpansionNode(
        SyntaxInfo syntax,
        IReadOnlyList<String>? @operator,
        IReadOnlyList<cIAstNode> parts)
        : base(syntax, ExpressionNodeType.Expansion)
    {
        Operator = @operator;
        Parts = cExprNode.CopyList(parts, "parts");
    }

    public override T Accept<T>(IVisitor<T> visitor) => visitor.VisitExpansion(this);
}
