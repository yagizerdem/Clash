using Clash.Ast.Base;
using Clash.Ast.Nodes.Expr;
using Clash.Ast.Visitor;
using Runtime.Evaluator;
using Runtime.Evaluator.Interface;

class VisitUnaryExpression : AbstractEvaluator<Result>
{
    private readonly cUnaryExpressionNode node_;

    public VisitUnaryExpression(ConcreateBaseAstVisitor<Result> cIAstNodeVisitor, cIAstNode node) : base(cIAstNodeVisitor, node)
    {
        this.node_ = (cUnaryExpressionNode)node;
    }

    override public Result Evaluate()
    {
        return new EmptyResult();
    }
}
