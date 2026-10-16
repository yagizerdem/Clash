

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

        StringResult variable = (StringResult)this.forStatementNode.Variable.Accept(this.cIAstNodeVisitor);
        List<StringResult> values = new List<StringResult>();
        for(int i = 0; i < this.forStatementNode.Values.Count; i++)
        {
            values.Add((StringResult)this.forStatementNode.Values[i].Accept(this.cIAstNodeVisitor));
        }
        
        
        this.forStatementNode.Body.Accept(this.cIAstNodeVisitor);

        return new EmptyResult();
    }
}