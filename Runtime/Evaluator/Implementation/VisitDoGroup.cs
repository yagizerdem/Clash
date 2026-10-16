using Clash.Ast.Base;
using Clash.Ast.Nodes.Other;
using Clash.Ast.Visitor;
using Runtime.Evaluator;
using Runtime.Evaluator.Interface;

class VisitDoGroup : AbstractEvaluator<Result>
{
    private readonly cDoGroupNode node_;

    public VisitDoGroup(ConcreateBaseAstVisitor<Result> cIAstNodeVisitor, cIAstNode node) : base(cIAstNodeVisitor, node)
    {
        this.node_ = (cDoGroupNode)node;
    }

    override public Result Evaluate()
    {
        return new EmptyResult();
    }
}
