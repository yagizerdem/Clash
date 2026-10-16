using Clash.Ast.Base;
using Clash.Ast.Nodes.Other;
using Clash.Ast.Visitor;
using Runtime.Evaluator;
using Runtime.Evaluator.Interface;

class VisitElseClause : AbstractEvaluator<Result>
{
    private readonly cElseClauseNode node_;

    public VisitElseClause(ConcreateBaseAstVisitor<Result> cIAstNodeVisitor, cIAstNode node) : base(cIAstNodeVisitor, node)
    {
        this.node_ = (cElseClauseNode)node;
    }

    override public Result Evaluate()
    {
        return new EmptyResult();
    }
}
