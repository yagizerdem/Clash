using Clash.Ast.Base;
using Clash.Ast.Nodes.Expr;
using Clash.Ast.Visitor;
using Runtime.Evaluator;
using Runtime.Evaluator.Interface;

class VisitBinaryExpression : AbstractEvaluator<Result>
{
    private readonly cBinaryExpressionNode node_;

    public VisitBinaryExpression(ConcreateBaseAstVisitor<Result> cIAstNodeVisitor, cIAstNode node) : base(cIAstNodeVisitor, node)
    {
        this.node_ = (cBinaryExpressionNode)node;
    }

    override public Result Evaluate()
    {
        return new EmptyResult();
    }
}
