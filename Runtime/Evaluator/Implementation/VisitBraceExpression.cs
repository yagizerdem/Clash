using Clash.Ast.Base;
using Clash.Ast.Nodes.PrimaryExpr;
using Clash.Ast.Visitor;
using Runtime.Evaluator;
using Runtime.Evaluator.Interface;

class VisitBraceExpression : AbstractEvaluator<Result>
{
    private readonly cBraceExpressionNode node_;

    public VisitBraceExpression(ConcreateBaseAstVisitor<Result> cIAstNodeVisitor, cIAstNode node) : base(cIAstNodeVisitor, node)
    {
        this.node_ = (cBraceExpressionNode)node;
    }

    override public Result Evaluate()
    {
        return new EmptyResult();
    }
}
