using Clash.Ast.Visitor;

namespace Clash.Ast.Base;

public class cConcreteBaseAstNode: cBaseAstNode
{

    public cConcreteBaseAstNode(SyntaxInfo syntax) : base(syntax)
    {
        
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitConcreteBase<T>(this);
}
