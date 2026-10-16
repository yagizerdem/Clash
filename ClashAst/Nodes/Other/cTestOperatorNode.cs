using Clash.Ast.Base;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Other;

public sealed class cTestOperatorNode : cBaseAstNode
{
    public string? Operator { get; }

    public cTestOperatorNode(
        SyntaxInfo syntax,
        string? @operator)
        : base(syntax)
    {
        Operator = @operator;
    }

    public override T Accept<T>(IVisitor<T> visitor) => visitor.VisitTestOperator(this);
}
