using Clash.Ast.Base;
using Clash.Ast.Nodes.Stmt;
using Clash.Ast.Visitor;
using Runtime.Evaluator;
using Runtime.Evaluator.Interface;

class VisitSubshell : AbstractEvaluator<Result>
{
    private readonly cSubshellNode node_;

    public VisitSubshell(ConcreateBaseAstVisitor<Result> cIAstNodeVisitor, cIAstNode node) : base(cIAstNodeVisitor, node)
    {
        this.node_ = (cSubshellNode)node;
    }

    override public Result Evaluate()
    {
        return new EmptyResult();
    }
}
