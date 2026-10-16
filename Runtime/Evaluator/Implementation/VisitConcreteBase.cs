using Clash.Ast.Base;
using Clash.Ast.Base;
using Clash.Ast.Visitor;
using Runtime.Evaluator;
using Runtime.Evaluator.Interface;

class VisitConcreteBase : AbstractEvaluator<Result>
{
    private readonly cConcreteBaseAstNode node_;

    public VisitConcreteBase(ConcreateBaseAstVisitor<Result> cIAstNodeVisitor, cIAstNode node) : base(cIAstNodeVisitor, node)
    {
        this.node_ = (cConcreteBaseAstNode)node;
    }

    override public Result Evaluate()
    {
        return new EmptyResult();
    }
}
