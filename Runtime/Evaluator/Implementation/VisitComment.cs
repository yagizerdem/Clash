using Clash.Ast.Base;
using Clash.Ast.Nodes.Other;
using Clash.Ast.Visitor;
using Runtime.Evaluator;
using Runtime.Evaluator.Interface;

class VisitComment : AbstractEvaluator<Result>
{
    private readonly cCommentNode node_;

    public VisitComment(ConcreateBaseAstVisitor<Result> cIAstNodeVisitor, cIAstNode node) : base(cIAstNodeVisitor, node)
    {
        this.node_ = (cCommentNode)node;
    }

    override public Result Evaluate()
    {
        return new EmptyResult();
    }
}
