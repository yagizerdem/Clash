using Clash.Ast.Base;
using Clash.Ast.Nodes.Other;
using Clash.Ast.Visitor;
using Runtime.Evaluator;
using Runtime.Evaluator.Interface;

class VisitFileDescriptor : AbstractEvaluator<Result>
{
    private readonly cFileDescriptorNode node_;

    public VisitFileDescriptor(ConcreateBaseAstVisitor<Result> cIAstNodeVisitor, cIAstNode node) : base(cIAstNodeVisitor, node)
    {
        this.node_ = (cFileDescriptorNode)node;
    }

    override public Result Evaluate()
    {
        return new EmptyResult();
    }
}
