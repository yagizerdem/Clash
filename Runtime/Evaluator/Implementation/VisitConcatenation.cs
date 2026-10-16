using Clash.Ast.Base;
using Clash.Ast.Nodes.Expr;
using Clash.Ast.Visitor;
using Runtime.Evaluator;
using Runtime.Evaluator.Interface;

class VisitConcatenation : AbstractEvaluator<Result>
{
    private readonly cConcatenationNode node_;

    public VisitConcatenation(ConcreateBaseAstVisitor<Result> cIAstNodeVisitor, cIAstNode node) : base(cIAstNodeVisitor, node)
    {
        this.node_ = (cConcatenationNode)node;
    }

    override public Result Evaluate()
    {
        return new EmptyResult();
    }
}
