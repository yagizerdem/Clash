using Clash.Ast.Base;
using Clash.Ast.Nodes.Stmt;
using Clash.Ast.Visitor;
using Runtime.Evaluator;
using Runtime.Evaluator.Interface;

class VisitNegatedCommand : AbstractEvaluator<Result>
{
    private readonly cNegatedCommandNode node_;

    public VisitNegatedCommand(ConcreateBaseAstVisitor<Result> cIAstNodeVisitor, cIAstNode node) : base(cIAstNodeVisitor, node)
    {
        this.node_ = (cNegatedCommandNode)node;
    }

    override public Result Evaluate()
    {
        return new EmptyResult();
    }
}
