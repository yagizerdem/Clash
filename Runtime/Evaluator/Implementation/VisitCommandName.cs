using Clash.Ast.Base;
using Clash.Ast.Nodes.Other;
using Clash.Ast.Visitor;
using Runtime.Evaluator;
using Runtime.Evaluator.Interface;

class VisitCommandName : AbstractEvaluator<Result>
{
    private readonly cCommandNameNode node_;

    public VisitCommandName(ConcreateBaseAstVisitor<Result> cIAstNodeVisitor, cIAstNode node) : base(cIAstNodeVisitor, node)
    {
        this.node_ = (cCommandNameNode)node;
    }

    override public Result Evaluate()
    {
        return new EmptyResult();
    }
}
