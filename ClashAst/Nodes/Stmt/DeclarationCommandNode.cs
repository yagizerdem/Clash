using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Stmt;

public sealed class DeclarationCommandNode : StmtNode
{
    public DeclarationKind DeclarationKind { get; }
    public IReadOnlyList<IAstNode> Arguments { get; }

    public DeclarationCommandNode(
        SyntaxInfo syntax,
        DeclarationKind declarationKind,
        IReadOnlyList<IAstNode> arguments)
        : base(syntax, StatementNodeType.DeclarationCommand)
    {
        DeclarationKind = StmtNode.Required(declarationKind, "declarationKind");
        Arguments = StmtNode.CopyList(arguments, "arguments");
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitDeclarationCommand<T>(this);
}
