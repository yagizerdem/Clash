using Clash.Ast.Enums;

namespace Clash.Ast.Base;

public abstract class PrimaryExprNode : ExprNode
{
    public PrimaryExprNode(SyntaxInfo syntax, ExpressionNodeType type) 
    : base(Required(syntax, nameof(syntax)), Required(type, nameof(type)))
    {
        
    }
}
