using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.PrimaryExpr;

public sealed class CommandSubstitutionNode : PrimaryExprNode
{
    public IReadOnlyList<IAstNode> Statements { get; }
    public IAstNode? Redirect { get; }

    public CommandSubstitutionNode(
        SyntaxInfo syntax,
        IReadOnlyList<IAstNode> statements,
        IAstNode? redirect)
        : base(syntax, ExpressionNodeType.CommandSubstitution)
    {
        Statements = ExprNode.CopyList(statements, "statements");
        Redirect = redirect;
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitCommandSubstitution<T>(this);
}
