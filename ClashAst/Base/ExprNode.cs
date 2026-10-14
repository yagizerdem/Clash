using Clash.Ast.Enums;

namespace Clash.Ast.Base;

public abstract class ExprNode : BaseAstNode
{
    public ExpressionNodeType Type { get; }

    protected ExprNode(SyntaxInfo syntax, ExpressionNodeType type) : base(Required(syntax, nameof(syntax)))
    {
        Type = Required(type, nameof(type));
    }

}
