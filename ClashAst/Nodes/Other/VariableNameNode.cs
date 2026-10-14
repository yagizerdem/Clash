using Clash.Ast.Base;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Other;

public class VariableNameNode : BaseAstNode
{
    public string? Var { get; }

    public VariableNameNode(
        SyntaxInfo syntax,
        string? identifier)
        : base(syntax)
    {
        Var = identifier;
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitVariableName<T>(this);
}
