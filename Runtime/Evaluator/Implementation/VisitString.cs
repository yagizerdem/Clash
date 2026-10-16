using Clash.Ast.Base;
using Clash.Ast.Nodes.PrimaryExpr;
using Clash.Ast.Visitor;
using Runtime.Evaluator;
using Runtime.Evaluator.Interface;

class VisitString : AbstractEvaluator<Result>
{
    private readonly cStringNode node_;

    public VisitString(ConcreateBaseAstVisitor<Result> cIAstNodeVisitor, cIAstNode node) : base(cIAstNodeVisitor, node)
    {
        this.node_ = (cStringNode)node;
    }

    override public Result Evaluate()
    {
        return new EmptyResult();
    }
}
