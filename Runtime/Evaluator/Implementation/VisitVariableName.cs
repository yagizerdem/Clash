using Clash.Ast.Base;
using Clash.Ast.Nodes.Other;
using Clash.Ast.Visitor;
using Runtime.Evaluator;
using Runtime.Evaluator.Interface;

class VisitVariableName : AbstractEvaluator<Result>
{
    private readonly cVariableNameNode node_;

    public VisitVariableName(ConcreateBaseAstVisitor<Result> cIAstNodeVisitor, cIAstNode node) : base(cIAstNodeVisitor, node)
    {
        this.node_ = (cVariableNameNode)node;
    }

    override public Result Evaluate()
    {
        string identifier = this.node_.Syntax.Raw;
        return new StringResult(identifier);
    }
}
