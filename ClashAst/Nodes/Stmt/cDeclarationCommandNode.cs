using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Stmt;

public sealed class cDeclarationCommandNode : cStmtNode
{
    public DeclarationKind DeclarationKind { get; }
    public IReadOnlyList<cIAstNode> Arguments { get; }

    public cDeclarationCommandNode(
        SyntaxInfo syntax,
        DeclarationKind declarationKind,
        IReadOnlyList<cIAstNode> arguments)
        : base(syntax, StatementNodeType.DeclarationCommand)
    {
        DeclarationKind = cStmtNode.Required(declarationKind, "declarationKind");
        Arguments = cStmtNode.CopyList(arguments, "arguments");
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitDeclarationCommand<T>(this);
}
