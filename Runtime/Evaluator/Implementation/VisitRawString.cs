using Clash.Ast.Base;
using Clash.Ast.Nodes.PrimaryExpr;
using Clash.Ast.Visitor;
using Runtime.Evaluator;
using Runtime.Evaluator.Interface;

class VisitRawString : AbstractEvaluator<Result>
{
    private readonly cRawStringNode node_;

    public VisitRawString(ConcreateBaseAstVisitor<Result> cIAstNodeVisitor, cIAstNode node) : base(cIAstNodeVisitor, node)
    {
        this.node_ = (cRawStringNode)node;
    }

    override public Result Evaluate()
    {
        return new EmptyResult();
    }
}
