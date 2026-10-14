using Clash.Ast.Enums;

namespace Clash.Ast.Base;

public abstract class StmtNode : BaseAstNode
{
    public StatementNodeType Type { get; }

    protected StmtNode(SyntaxInfo syntax, StatementNodeType type) : base(Required(syntax, nameof(syntax)))
    {
        Type = Required(type, nameof(type));
    }



}
