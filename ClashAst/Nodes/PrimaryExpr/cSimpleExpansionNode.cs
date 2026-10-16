using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.PrimaryExpr;

public sealed class cSimpleExpansionNode : cPrimaryExprNode
{
    public cIAstNode Variable { get; }

    public cSimpleExpansionNode(
        SyntaxInfo syntax,
        cIAstNode variable)
        : base(syntax, ExpressionNodeType.SimpleExpansion)
    {
        Variable = cExprNode.Required(variable, "variable");
    }

    public override T Accept<T>(IVisitor<T> visitor) => visitor.VisitSimpleExpansion(this);
}
