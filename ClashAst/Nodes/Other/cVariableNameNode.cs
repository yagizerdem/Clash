using Clash.Ast.Base;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Other;

public class cVariableNameNode : cBaseAstNode
{
    public string? Var { get; }

    public cVariableNameNode(
        SyntaxInfo syntax,
        string? identifier)
        : base(syntax)
    {
        Var = identifier;
    }

    public override T Accept<T>(IVisitor<T> visitor) => visitor.VisitVariableName(this);
}
