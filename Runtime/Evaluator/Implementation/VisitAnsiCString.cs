using Clash.Ast.Base;
using Clash.Ast.Nodes.PrimaryExpr;
using Clash.Ast.Visitor;
using Runtime.Evaluator;
using Runtime.Evaluator.Interface;

class VisitAnsiCString : AbstractEvaluator<Result>
{
    private readonly cAnsiCStringNode node_;

    public VisitAnsiCString(ConcreateBaseAstVisitor<Result> cIAstNodeVisitor, cIAstNode node) : base(cIAstNodeVisitor, node)
    {
        this.node_ = (cAnsiCStringNode)node;
    }

    override public Result Evaluate()
    {
        return new EmptyResult();
    }
}
