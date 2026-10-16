using Clash.Ast.Base;
using Clash.Ast.Nodes.Other;
using Clash.Ast.Visitor;
using Runtime.Evaluator;
using Runtime.Evaluator.Interface;

class VisitSpecialVariableName : AbstractEvaluator<Result>
{
    private readonly cSpecialVariableNameNode node_;

    public VisitSpecialVariableName(ConcreateBaseAstVisitor<Result> cIAstNodeVisitor, cIAstNode node) : base(cIAstNodeVisitor, node)
    {
        this.node_ = (cSpecialVariableNameNode)node;
    }

    override public Result Evaluate()
    {
        return new EmptyResult();
    }
}
