using Clash.Ast.Base;
using Clash.Ast.Nodes.Stmt;
using Clash.Ast.Visitor;
using Runtime.Evaluator;
using Runtime.Evaluator.Interface;

class VisitIfStatement : AbstractEvaluator<Result>
{
    private readonly cIfStatementNode node_;

    public VisitIfStatement(ConcreateBaseAstVisitor<Result> cIAstNodeVisitor, cIAstNode node) : base(cIAstNodeVisitor, node)
    {
        this.node_ = (cIfStatementNode)node;
    }

    override public Result Evaluate()
    {
        return new EmptyResult();
    }
}
