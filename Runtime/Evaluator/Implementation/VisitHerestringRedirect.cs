using Clash.Ast.Base;
using Clash.Ast.Nodes.Other;
using Clash.Ast.Visitor;
using Runtime.Evaluator;
using Runtime.Evaluator.Interface;

class VisitHerestringRedirect : AbstractEvaluator<Result>
{
    private readonly cHerestringRedirectNode node_;

    public VisitHerestringRedirect(ConcreateBaseAstVisitor<Result> cIAstNodeVisitor, cIAstNode node) : base(cIAstNodeVisitor, node)
    {
        this.node_ = (cHerestringRedirectNode)node;
    }

    override public Result Evaluate()
    {
        return new EmptyResult();
    }
}
