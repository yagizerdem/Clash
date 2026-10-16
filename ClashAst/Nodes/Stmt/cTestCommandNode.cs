using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Stmt;

public sealed class cTestCommandNode : cStmtNode
{
    public cIAstNode? Expression { get; }

    public cTestCommandNode(
        SyntaxInfo syntax,
        cIAstNode? expression)
        : base(syntax, StatementNodeType.TestCommand)
    {
        Expression = expression;
    }

    public override T Accept<T>(IVisitor<T> visitor) => visitor.VisitTestCommand(this);
}
