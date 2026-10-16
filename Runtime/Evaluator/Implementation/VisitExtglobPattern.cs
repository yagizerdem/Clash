using Clash.Ast.Base;
using Clash.Ast.Nodes.Other;
using Clash.Ast.Visitor;
using Runtime.Evaluator;
using Runtime.Evaluator.Interface;

class VisitExtglobPattern : AbstractEvaluator<Result>
{
    private readonly cExtglobPatternNode node_;

    public VisitExtglobPattern(ConcreateBaseAstVisitor<Result> cIAstNodeVisitor, cIAstNode node) : base(cIAstNodeVisitor, node)
    {
        this.node_ = (cExtglobPatternNode)node;
    }

    override public Result Evaluate()
    {
        return new EmptyResult();
    }
}
