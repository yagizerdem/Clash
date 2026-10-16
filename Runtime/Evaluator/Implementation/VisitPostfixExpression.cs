using Clash.Ast.Base;
using Clash.Ast.Nodes.Expr;
using Clash.Ast.Visitor;
using Runtime.Evaluator;
using Runtime.Evaluator.Interface;

class VisitPostfixExpression : AbstractEvaluator<Result>
{
    private readonly cPostfixExpressionNode node_;

    public VisitPostfixExpression(ConcreateBaseAstVisitor<Result> cIAstNodeVisitor, cIAstNode node) : base(cIAstNodeVisitor, node)
    {
        this.node_ = (cPostfixExpressionNode)node;
    }

    override public Result Evaluate()
    {
        return new EmptyResult();
    }
}
