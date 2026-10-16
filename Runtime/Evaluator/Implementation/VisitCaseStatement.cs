using Clash.Ast.Base;
using Clash.Ast.Nodes.Stmt;
using Clash.Ast.Visitor;
using Runtime.Evaluator;
using Runtime.Evaluator.Interface;

class VisitCaseStatement : AbstractEvaluator<Result>
{
    private readonly cCaseStatementNode node_;

    public VisitCaseStatement(ConcreateBaseAstVisitor<Result> cIAstNodeVisitor, cIAstNode node) : base(cIAstNodeVisitor, node)
    {
        this.node_ = (cCaseStatementNode)node;
    }

    override public Result Evaluate()
    {
        return new EmptyResult();
    }
}
