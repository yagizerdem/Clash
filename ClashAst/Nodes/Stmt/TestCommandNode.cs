using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Stmt;

public sealed class TestCommandNode : StmtNode
{
    public IAstNode? Expression { get; }

    public TestCommandNode(
        SyntaxInfo syntax,
        IAstNode? expression)
        : base(syntax, StatementNodeType.TestCommand)
    {
        Expression = expression;
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitTestCommand<T>(this);
}
