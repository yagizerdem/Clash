using Clash.Ast.Base;
using Clash.Ast.Nodes.PrimaryExpr;
using Clash.Ast.Visitor;
using Runtime.Evaluator;
using Runtime.Evaluator.Interface;

class VisitProcessSubstitution : AbstractEvaluator<Result>
{
    private readonly cProcessSubstitutionNode node_;

    public VisitProcessSubstitution(ConcreateBaseAstVisitor<Result> cIAstNodeVisitor, cIAstNode node) : base(cIAstNodeVisitor, node)
    {
        this.node_ = (cProcessSubstitutionNode)node;
    }

    override public Result Evaluate()
    {
        return new EmptyResult();
    }
}
