using Clash.Ast.Base;
using Clash.Ast.Nodes.Stmt;
using Clash.Ast.Visitor;
using Runtime.Evaluator;
using Runtime.Evaluator.Interface;

class VisitCStyleForStatement : AbstractEvaluator<Result>
{
    private readonly cCStyleForStatementNode node_;

    public VisitCStyleForStatement(ConcreateBaseAstVisitor<Result> cIAstNodeVisitor, cIAstNode node) : base(cIAstNodeVisitor, node)
    {
        this.node_ = (cCStyleForStatementNode)node;
    }

    override public Result Evaluate()
    {
        return new EmptyResult();
    }
}
