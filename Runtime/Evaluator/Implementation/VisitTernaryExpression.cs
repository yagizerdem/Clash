using Clash.Ast.Base;
using Clash.Ast.Nodes.Expr;
using Clash.Ast.Visitor;
using Runtime.Evaluator;
using Runtime.Evaluator.Interface;

class VisitTernaryExpression : AbstractEvaluator<Result>
{
    private readonly cTernaryExpressionNode node_;

    public VisitTernaryExpression(ConcreateBaseAstVisitor<Result> cIAstNodeVisitor, cIAstNode node) : base(cIAstNodeVisitor, node)
    {
        this.node_ = (cTernaryExpressionNode)node;
    }

    override public Result Evaluate()
    {
        return new EmptyResult();
    }
}
