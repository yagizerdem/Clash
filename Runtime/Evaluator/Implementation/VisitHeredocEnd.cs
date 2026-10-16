using Clash.Ast.Base;
using Clash.Ast.Nodes.Other;
using Clash.Ast.Visitor;
using Runtime.Evaluator;
using Runtime.Evaluator.Interface;

class VisitHeredocEnd : AbstractEvaluator<Result>
{
    private readonly cHeredocEndNode node_;

    public VisitHeredocEnd(ConcreateBaseAstVisitor<Result> cIAstNodeVisitor, cIAstNode node) : base(cIAstNodeVisitor, node)
    {
        this.node_ = (cHeredocEndNode)node;
    }

    override public Result Evaluate()
    {
        return new EmptyResult();
    }
}
