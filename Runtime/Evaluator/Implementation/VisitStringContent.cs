using Clash.Ast.Base;
using Clash.Ast.Nodes.Other;
using Clash.Ast.Visitor;
using Runtime.Evaluator;
using Runtime.Evaluator.Interface;

class VisitStringContent : AbstractEvaluator<Result>
{
    private readonly cStringContentNode node_;

    public VisitStringContent(ConcreateBaseAstVisitor<Result> cIAstNodeVisitor, cIAstNode node) : base(cIAstNodeVisitor, node)
    {
        this.node_ = (cStringContentNode)node;
    }

    override public Result Evaluate()
    {
        return new EmptyResult();
    }
}
