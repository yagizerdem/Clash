using Clash.Ast.Base;
using Clash.Ast.Nodes.Other;
using Clash.Ast.Visitor;
using Runtime.Evaluator;
using Runtime.Evaluator.Interface;

class VisitElifClause : AbstractEvaluator<Result>
{
    private readonly cElifClauseNode node_;

    public VisitElifClause(ConcreateBaseAstVisitor<Result> cIAstNodeVisitor, cIAstNode node) : base(cIAstNodeVisitor, node)
    {
        this.node_ = (cElifClauseNode)node;
    }

    override public Result Evaluate()
    {
        return new EmptyResult();
    }
}
