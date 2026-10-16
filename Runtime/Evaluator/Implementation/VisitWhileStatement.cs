using Clash.Ast.Base;
using Clash.Ast.Nodes.Stmt;
using Clash.Ast.Visitor;
using Runtime.Evaluator;
using Runtime.Evaluator.Interface;

class VisitWhileStatement : AbstractEvaluator<Result>
{
    private readonly cWhileStatementNode node_;

    public VisitWhileStatement(ConcreateBaseAstVisitor<Result> cIAstNodeVisitor, cIAstNode node) : base(cIAstNodeVisitor, node)
    {
        this.node_ = (cWhileStatementNode)node;
    }

    override public Result Evaluate()
    {
        return new EmptyResult();
    }
}
