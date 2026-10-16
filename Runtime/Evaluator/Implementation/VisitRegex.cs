using Clash.Ast.Base;
using Clash.Ast.Nodes.Other;
using Clash.Ast.Visitor;
using Runtime.Evaluator;
using Runtime.Evaluator.Interface;

class VisitRegex : AbstractEvaluator<Result>
{
    private readonly cRegexNode node_;

    public VisitRegex(ConcreateBaseAstVisitor<Result> cIAstNodeVisitor, cIAstNode node) : base(cIAstNodeVisitor, node)
    {
        this.node_ = (cRegexNode)node;
    }

    override public Result Evaluate()
    {
        return new EmptyResult();
    }
}
