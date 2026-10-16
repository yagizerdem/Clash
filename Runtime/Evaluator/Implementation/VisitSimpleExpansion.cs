using Clash.Ast.Base;
using Clash.Ast.Nodes.PrimaryExpr;
using Clash.Ast.Visitor;
using Runtime.Evaluator;
using Runtime.Evaluator.Interface;

class VisitSimpleExpansion : AbstractEvaluator<Result>
{
    private readonly cSimpleExpansionNode node_;

    public VisitSimpleExpansion(ConcreateBaseAstVisitor<Result> cIAstNodeVisitor, cIAstNode node) : base(cIAstNodeVisitor, node)
    {
        this.node_ = (cSimpleExpansionNode)node;
    }

    override public Result Evaluate()
    {
        return new EmptyResult();
    }
}
