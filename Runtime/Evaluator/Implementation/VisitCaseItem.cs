using Clash.Ast.Base;
using Clash.Ast.Nodes.Other;
using Clash.Ast.Visitor;
using Runtime.Evaluator;
using Runtime.Evaluator.Interface;

class VisitCaseItem : AbstractEvaluator<Result>
{
    private readonly cCaseItemNode node_;

    public VisitCaseItem(ConcreateBaseAstVisitor<Result> cIAstNodeVisitor, cIAstNode node) : base(cIAstNodeVisitor, node)
    {
        this.node_ = (cCaseItemNode)node;
    }

    override public Result Evaluate()
    {
        return new EmptyResult();
    }
}
