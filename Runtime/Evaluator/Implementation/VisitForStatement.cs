

using Clash.Ast.Base;
using Clash.Ast.Nodes.Stmt;
using Clash.Ast.Visitor;
using Runtime.Evaluator;
using Runtime.Evaluator.Interface;

class VisitForStatement : AbstractEvaluator<Result>
{
    cForStatementNode forStatementNode;
    public VisitForStatement(ConcreateBaseAstVisitor<Result> cIAstNodeVisitor, cIAstNode node) : base(cIAstNodeVisitor, node)
    {
        this.forStatementNode = (cForStatementNode)node;
    }

    override public Result Evaluate()
    {

        this.forStatementNode.Variable.Accept(this.cIAstNodeVisitor);
        for(int i = 0; i < this.forStatementNode.Values.Count; i++)
        {
            this.forStatementNode.Values[i].Accept(this.cIAstNodeVisitor);
        }
        this.forStatementNode.Body.Accept(this.cIAstNodeVisitor);

        return new EmptyResult();
    }
}