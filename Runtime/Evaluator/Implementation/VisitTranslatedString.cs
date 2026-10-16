using Clash.Ast.Base;
using Clash.Ast.Nodes.PrimaryExpr;
using Clash.Ast.Visitor;
using Runtime.Evaluator;
using Runtime.Evaluator.Interface;

class VisitTranslatedString : AbstractEvaluator<Result>
{
    private readonly cTranslatedStringNode node_;

    public VisitTranslatedString(ConcreateBaseAstVisitor<Result> cIAstNodeVisitor, cIAstNode node) : base(cIAstNodeVisitor, node)
    {
        this.node_ = (cTranslatedStringNode)node;
    }

    override public Result Evaluate()
    {
        return new EmptyResult();
    }
}
