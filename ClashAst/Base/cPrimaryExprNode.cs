using Clash.Ast.Enums;

namespace Clash.Ast.Base;

public abstract class cPrimaryExprNode : cExprNode
{
    public cPrimaryExprNode(SyntaxInfo syntax, ExpressionNodeType type) 
    : base(Required(syntax, nameof(syntax)), Required(type, nameof(type)))
    {
        
    }
}
