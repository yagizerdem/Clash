using Clash.Ast.Base;
using Clash.Ast.Nodes.Other;
using Clash.Ast.Visitor;
using Runtime.Evaluator;
using Runtime.Evaluator.Interface;

class VisitHeredocBody : AbstractEvaluator<Result>
{
    private readonly cHeredocBodyNode node_;

    public VisitHeredocBody(ConcreateBaseAstVisitor<Result> cIAstNodeVisitor, cIAstNode node) : base(cIAstNodeVisitor, node)
    {
        this.node_ = (cHeredocBodyNode)node;
    }

    override public Result Evaluate()
    {
        return new EmptyResult();
    }
}
