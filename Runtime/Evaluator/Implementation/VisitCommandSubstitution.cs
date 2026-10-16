using Clash.Ast.Base;
using Clash.Ast.Nodes.PrimaryExpr;
using Clash.Ast.Visitor;
using Runtime.Evaluator;
using Runtime.Evaluator.Interface;

class VisitCommandSubstitution : AbstractEvaluator<Result>
{
    private readonly cCommandSubstitutionNode node_;

    public VisitCommandSubstitution(ConcreateBaseAstVisitor<Result> cIAstNodeVisitor, cIAstNode node) : base(cIAstNodeVisitor, node)
    {
        this.node_ = (cCommandSubstitutionNode)node;
    }

    override public Result Evaluate()
    {
        return new EmptyResult();
    }
}
