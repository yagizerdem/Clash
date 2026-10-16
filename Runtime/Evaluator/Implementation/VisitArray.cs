using Clash.Ast.Base;
using Clash.Ast.Nodes.Other;
using Clash.Ast.Visitor;
using Runtime.Evaluator;
using Runtime.Evaluator.Interface;

class VisitArray : AbstractEvaluator<Result>
{
    private readonly cArrayNode node_;

    public VisitArray(ConcreateBaseAstVisitor<Result> cIAstNodeVisitor, cIAstNode node) : base(cIAstNodeVisitor, node)
    {
        this.node_ = (cArrayNode)node;
    }

    override public Result Evaluate()
    {
        return new EmptyResult();
    }
}
