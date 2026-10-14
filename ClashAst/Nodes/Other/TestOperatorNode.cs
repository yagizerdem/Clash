using Clash.Ast.Base;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Other;

public sealed class TestOperatorNode : BaseAstNode
{
    public string? Operator { get; }

    public TestOperatorNode(
        SyntaxInfo syntax,
        string? @operator)
        : base(syntax)
    {
        Operator = @operator;
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitTestOperator<T>(this);
}
