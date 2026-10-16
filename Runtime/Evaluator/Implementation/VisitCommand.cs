using Clash.Ast.Base;
using Clash.Ast.Nodes.Stmt;
using Clash.Ast.Visitor;
using Runtime.Evaluator;
using Runtime.Evaluator.Interface;

class VisitCommand : AbstractEvaluator<Result>
{
    private readonly cCommandNode node_;

    public VisitCommand(ConcreateBaseAstVisitor<Result> cIAstNodeVisitor, cIAstNode node) : base(cIAstNodeVisitor, node)
    {
        this.node_ = (cCommandNode)node;
    }

    override public Result Evaluate()
    {
        return new EmptyResult();
    }
}
