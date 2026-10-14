using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.PrimaryExpr;

public sealed class TranslatedStringNode : PrimaryExprNode
{
    public IAstNode Value { get; }

    public TranslatedStringNode(
        SyntaxInfo syntax,
        IAstNode value)
        : base(syntax, ExpressionNodeType.TranslatedString)
    {
        Value = ExprNode.Required(value, "value");
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitTranslatedString<T>(this);
}
