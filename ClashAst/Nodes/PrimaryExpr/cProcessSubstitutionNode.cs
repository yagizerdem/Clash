using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.PrimaryExpr;

public sealed class cProcessSubstitutionNode : cPrimaryExprNode
{
    public IReadOnlyList<cIAstNode> Statements { get; }

    public cProcessSubstitutionNode(
        SyntaxInfo syntax,
        IReadOnlyList<cIAstNode> statements)
        : base(syntax, ExpressionNodeType.ProcessSubstitution)
    {
        Statements = cExprNode.CopyList(statements, "statements");
    }

    public override T Accept<T>(IVisitor<T> visitor) => visitor.VisitProcessSubstitution(this);
}
