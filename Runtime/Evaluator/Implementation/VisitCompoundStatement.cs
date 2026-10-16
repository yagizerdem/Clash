using Clash.Ast.Base;
using Clash.Ast.Nodes.Stmt;
using Clash.Ast.Visitor;
using Runtime.Evaluator;
using Runtime.Evaluator.Interface;

class VisitCompoundStatement : AbstractEvaluator<Result>
{
    private readonly cCompoundStatementNode node_;

    public VisitCompoundStatement(ConcreateBaseAstVisitor<Result> cIAstNodeVisitor, cIAstNode node) : base(cIAstNodeVisitor, node)
    {
        this.node_ = (cCompoundStatementNode)node;
    }

    override public Result Evaluate()
    {
        return new EmptyResult();
    }
}
