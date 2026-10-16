using Clash.Ast.Base;
using Clash.Ast.Nodes.Stmt;
using Clash.Ast.Visitor;
using Runtime.Evaluator;
using Runtime.Evaluator.Interface;

class VisitDeclarationCommand : AbstractEvaluator<Result>
{
    private readonly cDeclarationCommandNode node_;

    public VisitDeclarationCommand(ConcreateBaseAstVisitor<Result> cIAstNodeVisitor, cIAstNode node) : base(cIAstNodeVisitor, node)
    {
        this.node_ = (cDeclarationCommandNode)node;
    }

    override public Result Evaluate()
    {
        return new EmptyResult();
    }
}
