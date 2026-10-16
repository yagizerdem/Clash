using Clash.Ast.Base;
using Clash.Ast.Nodes.Other;
using Clash.Ast.Visitor;
using Runtime.Evaluator;
using Runtime.Evaluator.Interface;

class VisitHeredocContent : AbstractEvaluator<Result>
{
    private readonly cHeredocContentNode node_;

    public VisitHeredocContent(ConcreateBaseAstVisitor<Result> cIAstNodeVisitor, cIAstNode node) : base(cIAstNodeVisitor, node)
    {
        this.node_ = (cHeredocContentNode)node;
    }

    override public Result Evaluate()
    {
        return new EmptyResult();
    }
}
