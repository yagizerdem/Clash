using Clash.Ast.Base;
using Clash.Ast.Nodes.Stmt;
using Clash.Ast.Visitor;
using Runtime.Evaluator;
using Runtime.Evaluator.Interface;

class VisitRedirectedStatement : AbstractEvaluator<Result>
{
    private readonly cRedirectedStatementNode node_;

    public VisitRedirectedStatement(ConcreateBaseAstVisitor<Result> cIAstNodeVisitor, cIAstNode node) : base(cIAstNodeVisitor, node)
    {
        this.node_ = (cRedirectedStatementNode)node;
    }

    override public Result Evaluate()
    {
        return new EmptyResult();
    }
}
