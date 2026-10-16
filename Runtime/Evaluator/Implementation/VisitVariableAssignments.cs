using Clash.Ast.Base;
using Clash.Ast.Nodes.Stmt;
using Clash.Ast.Visitor;
using Runtime.Evaluator;
using Runtime.Evaluator.Interface;

class VisitVariableAssignments : AbstractEvaluator<Result>
{
    private readonly cVariableAssignmentsNode node_;

    public VisitVariableAssignments(ConcreateBaseAstVisitor<Result> cIAstNodeVisitor, cIAstNode node) : base(cIAstNodeVisitor, node)
    {
        this.node_ = (cVariableAssignmentsNode)node;
    }

    override public Result Evaluate()
    {
        return new EmptyResult();
    }
}
