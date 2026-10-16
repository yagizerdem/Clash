using Clash.Ast.Base;
using Clash.Ast.Nodes.Other;
using Clash.Ast.Visitor;
using Runtime.Evaluator;
using Runtime.Evaluator.Interface;

class VisitFileRedirect : AbstractEvaluator<Result>
{
    private readonly cFileRedirectNode node_;

    public VisitFileRedirect(ConcreateBaseAstVisitor<Result> cIAstNodeVisitor, cIAstNode node) : base(cIAstNodeVisitor, node)
    {
        this.node_ = (cFileRedirectNode)node;
    }

    override public Result Evaluate()
    {
        return new EmptyResult();
    }
}
