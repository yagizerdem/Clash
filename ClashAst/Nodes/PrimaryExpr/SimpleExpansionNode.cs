using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.PrimaryExpr;

public sealed class SimpleExpansionNode : PrimaryExprNode
{
    public IAstNode Variable { get; }

    public SimpleExpansionNode(
        SyntaxInfo syntax,
        IAstNode variable)
        : base(syntax, ExpressionNodeType.SimpleExpansion)
    {
        Variable = ExprNode.Required(variable, "variable");
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitSimpleExpansion<T>(this);
}
