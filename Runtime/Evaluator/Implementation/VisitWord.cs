using Clash.Ast.Base;
using Clash.Ast.Nodes.Expr;
using Clash.Ast.Visitor;
using Runtime.Evaluator;
using Runtime.Evaluator.Interface;

class VisitWord : AbstractEvaluator<Result>
{
    private readonly cWordNode node_;

    public VisitWord(ConcreateBaseAstVisitor<Result> cIAstNodeVisitor, cIAstNode node) : base(cIAstNodeVisitor, node)
    {
        this.node_ = (cWordNode)node;
    }

    override public Result Evaluate()
    {
        string value = this.node_.Syntax.Raw;
        return new StringResult(value);
    }
}
