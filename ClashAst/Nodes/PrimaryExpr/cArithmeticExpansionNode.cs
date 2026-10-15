using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.PrimaryExpr;

public sealed class cArithmeticExpansionNode : cPrimaryExprNode
{
    public IReadOnlyList<cIAstNode> Expressions { get; }

    public cArithmeticExpansionNode(
        SyntaxInfo syntax,
        IReadOnlyList<cIAstNode> expressions)
        : base(syntax, ExpressionNodeType.ArithmeticExpansion)
    {
        Expressions = cExprNode.CopyList(expressions, "expressions");
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitArithmeticExpansion<T>(this);
}
