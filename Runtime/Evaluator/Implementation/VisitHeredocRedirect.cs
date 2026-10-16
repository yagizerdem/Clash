using Clash.Ast.Base;
using Clash.Ast.Nodes.Other;
using Clash.Ast.Visitor;
using Runtime.Evaluator;
using Runtime.Evaluator.Interface;

class VisitHeredocRedirect : AbstractEvaluator<Result>
{
    private readonly cHeredocRedirectNode node_;

    public VisitHeredocRedirect(ConcreateBaseAstVisitor<Result> cIAstNodeVisitor, cIAstNode node) : base(cIAstNodeVisitor, node)
    {
        this.node_ = (cHeredocRedirectNode)node;
    }

    override public Result Evaluate()
    {
        return new EmptyResult();
    }
}
