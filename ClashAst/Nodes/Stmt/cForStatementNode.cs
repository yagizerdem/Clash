using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Stmt;

public sealed class cForStatementNode : cStmtNode
{
    public cIAstNode Variable { get; }
    public IReadOnlyList<cIAstNode> Values { get; }
    public cIAstNode Body { get; }

    public cForStatementNode(
        SyntaxInfo syntax,
        cIAstNode variable,
        IReadOnlyList<cIAstNode> values,
        cIAstNode body)
        : base(syntax, StatementNodeType.ForStatement)
    {
        Variable = cStmtNode.Required(variable, "variable");
        Values = cStmtNode.CopyList(values, "values");
        Body = cStmtNode.Required(body, "body");
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitForStatement<T>(this);
}
