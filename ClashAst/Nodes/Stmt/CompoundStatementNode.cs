using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Stmt;

public sealed class CompoundStatementNode : StmtNode
{
    public IReadOnlyList<IAstNode> Elements { get; }

    public CompoundStatementNode(
        SyntaxInfo syntax,
        IReadOnlyList<IAstNode> elements)
        : base(syntax, StatementNodeType.CompoundStatement)
    {
        Elements = StmtNode.CopyList(elements, "elements");
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitCompoundStatement<T>(this);
}
