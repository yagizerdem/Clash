

using Clash.Ast.Base;
using Clash.Ast.Nodes;
using Clash.Ast.Nodes.Stmt;
using Clash.Ast.Visitor;
using Runtime.Evaluator;
using Runtime.Evaluator.Interface;

class VisitProgram : AbstractEvaluator<Result>
{
    private readonly cProgramNode programNode;
    public VisitProgram(ConcreateBaseAstVisitor<Result> cIAstNodeVisitor, cIAstNode node) : base(cIAstNodeVisitor, node)
    {
        this.programNode = (cProgramNode)node;
    }

    override public Result Evaluate()
    {

        foreach (var stmt in this.programNode.Statements)
        {
            stmt.Accept(this.cIAstNodeVisitor);
        }

        return new EmptyResult();
    }
}