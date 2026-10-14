using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Stmt;

public sealed class cCompoundStatementNode : cStmtNode
{
    public IReadOnlyList<cIAstNode> Elements { get; }

    public cCompoundStatementNode(
        SyntaxInfo syntax,
        IReadOnlyList<cIAstNode> elements)
        : base(syntax, StatementNodeType.CompoundStatement)
    {
        Elements = cStmtNode.CopyList(elements, "elements");
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitCompoundStatement<T>(this);
}
