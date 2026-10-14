using Clash.Ast.Base;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Other;

public class SpecialVariableNameNode : BaseAstNode
{
    public string? Var { get; }

    public SpecialVariableNameNode(
        SyntaxInfo syntax,
        string? identifier)
        : base(syntax)
    {
        Var = identifier;
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitSpecialVariableName<T>(this);
}
