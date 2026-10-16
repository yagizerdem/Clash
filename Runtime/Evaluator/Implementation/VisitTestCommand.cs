using Clash.Ast.Base;
using Clash.Ast.Nodes.Stmt;
using Clash.Ast.Visitor;
using Runtime.Evaluator;
using Runtime.Evaluator.Interface;

class VisitTestCommand : AbstractEvaluator<Result>
{
    private readonly cTestCommandNode node_;

    public VisitTestCommand(ConcreateBaseAstVisitor<Result> cIAstNodeVisitor, cIAstNode node) : base(cIAstNodeVisitor, node)
    {
        this.node_ = (cTestCommandNode)node;
    }

    override public Result Evaluate()
    {
        return new EmptyResult();
    }
}
