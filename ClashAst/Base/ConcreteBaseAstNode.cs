using Clash.Ast.Visitor;

namespace Clash.Ast.Base;

public class ConcreteBaseAstNode: BaseAstNode
{

    public ConcreteBaseAstNode(SyntaxInfo syntax) : base(syntax)
    {
        
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitConcreteBase<T>(this);
}
