using Clash.Ast.Base;
using Clash.Ast.Nodes.Stmt;
using Clash.Ast.Visitor;
using Runtime.Evaluator;
using Runtime.Evaluator.Interface;

class VisitFunctionDefinition : AbstractEvaluator<Result>
{
    private readonly cFunctionDefinitionNode node_;

    public VisitFunctionDefinition(ConcreateBaseAstVisitor<Result> cIAstNodeVisitor, cIAstNode node) : base(cIAstNodeVisitor, node)
    {
        this.node_ = (cFunctionDefinitionNode)node;
    }

    override public Result Evaluate()
    {
        return new EmptyResult();
    }
}
