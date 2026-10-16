using Clash.Ast.Base;
using Clash.Ast.Nodes.Stmt;
using Clash.Ast.Visitor;
using Runtime.Evaluator;
using Runtime.Evaluator.Interface;

class VisitList : AbstractEvaluator<Result>
{
    private readonly cListNode node_;

    public VisitList(ConcreateBaseAstVisitor<Result> cIAstNodeVisitor, cIAstNode node) : base(cIAstNodeVisitor, node)
    {
        this.node_ = (cListNode)node;
    }

    override public Result Evaluate()
    {
        return new EmptyResult();
    }
}
