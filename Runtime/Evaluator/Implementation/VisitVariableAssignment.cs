using Clash.Ast.Base;
using Clash.Ast.Nodes.Stmt;
using Clash.Ast.Visitor;
using Runtime.Evaluator;
using Runtime.Evaluator.Interface;

class VisitVariableAssignment : AbstractEvaluator<Result>
{
    private readonly cVariableAssignmentNode node_;

    public VisitVariableAssignment(ConcreateBaseAstVisitor<Result> cIAstNodeVisitor, cIAstNode node) : base(cIAstNodeVisitor, node)
    {
        this.node_ = (cVariableAssignmentNode)node;
    }

    override public Result Evaluate()
    {
        return new EmptyResult();
    }
}
