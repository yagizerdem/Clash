using Clash.Ast.Base;
using Clash.Ast.Nodes.Other;
using Clash.Ast.Visitor;
using Runtime.Evaluator;
using Runtime.Evaluator.Interface;

class VisitHeredocStart : AbstractEvaluator<Result>
{
    private readonly cHeredocStartNode node_;

    public VisitHeredocStart(ConcreateBaseAstVisitor<Result> cIAstNodeVisitor, cIAstNode node) : base(cIAstNodeVisitor, node)
    {
        this.node_ = (cHeredocStartNode)node;
    }

    override public Result Evaluate()
    {
        return new EmptyResult();
    }
}
