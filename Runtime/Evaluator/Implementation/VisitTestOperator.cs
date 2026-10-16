using Clash.Ast.Base;
using Clash.Ast.Nodes.Other;
using Clash.Ast.Visitor;
using Runtime.Evaluator;
using Runtime.Evaluator.Interface;

class VisitTestOperator : AbstractEvaluator<Result>
{
    private readonly cTestOperatorNode node_;

    public VisitTestOperator(ConcreateBaseAstVisitor<Result> cIAstNodeVisitor, cIAstNode node) : base(cIAstNodeVisitor, node)
    {
        this.node_ = (cTestOperatorNode)node;
    }

    override public Result Evaluate()
    {
        return new EmptyResult();
    }
}
