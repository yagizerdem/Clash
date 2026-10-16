using Clash.Ast.Base;
using Clash.Ast.Nodes.Stmt;
using Clash.Ast.Visitor;
using Runtime.Evaluator;
using Runtime.Evaluator.Interface;

class VisitUnsetCommand : AbstractEvaluator<Result>
{
    private readonly cUnsetCommandNode node_;

    public VisitUnsetCommand(ConcreateBaseAstVisitor<Result> cIAstNodeVisitor, cIAstNode node) : base(cIAstNodeVisitor, node)
    {
        this.node_ = (cUnsetCommandNode)node;
    }

    override public Result Evaluate()
    {
        return new EmptyResult();
    }
}
