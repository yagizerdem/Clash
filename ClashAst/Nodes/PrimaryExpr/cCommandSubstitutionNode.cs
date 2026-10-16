using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.PrimaryExpr;

public sealed class cCommandSubstitutionNode : cPrimaryExprNode
{
    public IReadOnlyList<cIAstNode> Statements { get; }
    public cIAstNode? Redirect { get; }

    public cCommandSubstitutionNode(
        SyntaxInfo syntax,
        IReadOnlyList<cIAstNode> statements,
        cIAstNode? redirect)
        : base(syntax, ExpressionNodeType.CommandSubstitution)
    {
        Statements = cExprNode.CopyList(statements, "statements");
        Redirect = redirect;
    }

    public override T Accept<T>(IVisitor<T> visitor) => visitor.VisitCommandSubstitution(this);
}
