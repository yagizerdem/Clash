using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.PrimaryExpr;

public sealed class cTranslatedStringNode : cPrimaryExprNode
{
    public cIAstNode Value { get; }

    public cTranslatedStringNode(
        SyntaxInfo syntax,
        cIAstNode value)
        : base(syntax, ExpressionNodeType.TranslatedString)
    {
        Value = cExprNode.Required(value, "value");
    }

    public override T Accept<T>(IVisitor<T> visitor) => visitor.VisitTranslatedString(this);
}
