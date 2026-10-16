using Clash.Ast.Base;
using Clash.Ast.Nodes.Expr;
using Clash.Ast.Visitor;
using Runtime.Evaluator;
using Runtime.Evaluator.Interface;

class VisitParenthesizedExpression : AbstractEvaluator<Result>
{
    private readonly cParenthesizedExpressionNode node_;

    public VisitParenthesizedExpression(ConcreateBaseAstVisitor<Result> cIAstNodeVisitor, cIAstNode node) : base(cIAstNodeVisitor, node)
    {
        this.node_ = (cParenthesizedExpressionNode)node;
    }

    override public Result Evaluate()
    {
        return new EmptyResult();
    }
}
