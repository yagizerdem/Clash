using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Stmt;

public sealed class ForStatementNode : StmtNode
{
    public IAstNode Variable { get; }
    public IReadOnlyList<IAstNode> Values { get; }
    public IAstNode Body { get; }

    public ForStatementNode(
        SyntaxInfo syntax,
        IAstNode variable,
        IReadOnlyList<IAstNode> values,
        IAstNode body)
        : base(syntax, StatementNodeType.ForStatement)
    {
        Variable = StmtNode.Required(variable, "variable");
        Values = StmtNode.CopyList(values, "values");
        Body = StmtNode.Required(body, "body");
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitForStatement<T>(this);
}
