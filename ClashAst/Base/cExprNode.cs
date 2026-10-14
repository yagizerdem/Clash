using Clash.Ast.Enums;

namespace Clash.Ast.Base;

public abstract class cExprNode : cBaseAstNode
{
    public ExpressionNodeType Type { get; }

    protected cExprNode(SyntaxInfo syntax, ExpressionNodeType type) : base(Required(syntax, nameof(syntax)))
    {
        Type = Required(type, nameof(type));
    }

}
