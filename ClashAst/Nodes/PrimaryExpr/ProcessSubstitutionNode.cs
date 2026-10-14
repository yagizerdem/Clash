using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.PrimaryExpr;

public sealed class ProcessSubstitutionNode : PrimaryExprNode
{
    public IReadOnlyList<IAstNode> Statements { get; }

    public ProcessSubstitutionNode(
        SyntaxInfo syntax,
        IReadOnlyList<IAstNode> statements)
        : base(syntax, ExpressionNodeType.ProcessSubstitution)
    {
        Statements = ExprNode.CopyList(statements, "statements");
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitProcessSubstitution<T>(this);
}
