using Clash.Ast.Base;
using Clash.Ast.Nodes.Stmt;
using Clash.Ast.Visitor;
using Runtime.Evaluator;
using Runtime.Evaluator.Interface;

class VisitPipeline : AbstractEvaluator<Result>
{
    private readonly cPipelineNode node_;

    public VisitPipeline(ConcreateBaseAstVisitor<Result> cIAstNodeVisitor, cIAstNode node) : base(cIAstNodeVisitor, node)
    {
        this.node_ = (cPipelineNode)node;
    }

    override public Result Evaluate()
    {
        return new EmptyResult();
    }
}
