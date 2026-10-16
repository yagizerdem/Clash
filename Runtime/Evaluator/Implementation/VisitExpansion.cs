using Clash.Ast.Base;
using Clash.Ast.Nodes.PrimaryExpr;
using Clash.Ast.Visitor;
using Runtime.Evaluator;
using Runtime.Evaluator.Interface;

class VisitExpansion : AbstractEvaluator<Result>
{
    private readonly cExpansionNode node_;

    public VisitExpansion(ConcreateBaseAstVisitor<Result> cIAstNodeVisitor, cIAstNode node) : base(cIAstNodeVisitor, node)
    {
        this.node_ = (cExpansionNode)node;
    }

    override public Result Evaluate()
    {
        return new EmptyResult();
    }
}
