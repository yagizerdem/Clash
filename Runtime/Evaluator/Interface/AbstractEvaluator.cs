

using Clash.Ast.Base;
using Clash.Ast.Visitor;
using Runtime.Evaluator;
using Runtime.Evaluator.Interface;

abstract class AbstractEvaluator<T> : IEvaluator<T> where T : Result
{   

    public ConcreateBaseAstVisitor<T> cIAstNodeVisitor;
    public cIAstNode node;
    public AbstractEvaluator(ConcreateBaseAstVisitor<T> cIAstNodeVisitor, cIAstNode node)
    {
        this.cIAstNodeVisitor = cIAstNodeVisitor;
        this.node = node;
    }

    abstract public T Evaluate();
}