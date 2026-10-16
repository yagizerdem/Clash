using Clash.Ast.Nodes;
using Clash.Ast.Nodes.Stmt;
using Clash.Ast.Visitor;
using Runtime.Evaluator;
using Runtime.Evaluator.Interface;

class EvaluationDispatcher : ConcreateBaseAstVisitor<Result>
{

    public override Result VisitProgram(cProgramNode node)
    {
        IEvaluator<Result> evaluator = new VisitProgram(this, node);
        return evaluator.Evaluate();
    }

    public override Result VisitForStatement(cForStatementNode node)
    {
        IEvaluator<Result> evaluator = new VisitForStatement(this, node);
        return evaluator.Evaluate();
    }

    



}