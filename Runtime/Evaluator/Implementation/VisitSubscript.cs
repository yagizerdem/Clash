using Clash.Ast.Base;
using Clash.Ast.Nodes.Other;
using Clash.Ast.Visitor;
using Runtime.Evaluator;
using Runtime.Evaluator.Interface;

class VisitSubscript : AbstractEvaluator<Result>
{
    private readonly cSubscriptNode node_;

    public VisitSubscript(ConcreateBaseAstVisitor<Result> cIAstNodeVisitor, cIAstNode node) : base(cIAstNodeVisitor, node)
    {
        this.node_ = (cSubscriptNode)node;
    }

    override public Result Evaluate()
    {
        return new EmptyResult();
    }
}
