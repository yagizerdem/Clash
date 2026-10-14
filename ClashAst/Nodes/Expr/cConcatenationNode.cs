using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Expr;

public sealed class cConcatenationNode : cExprNode
{
    public IReadOnlyList<cIAstNode> Parts { get; }

    public cConcatenationNode(
        SyntaxInfo syntax,
        IReadOnlyList<cIAstNode> parts)
        : base(syntax, ExpressionNodeType.Concatenation)
    {
        Parts = cExprNode.CopyList(parts, "parts");
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitConcatenation<T>(this);
}
