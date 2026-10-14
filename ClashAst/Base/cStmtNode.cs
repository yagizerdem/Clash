using Clash.Ast.Enums;

namespace Clash.Ast.Base;

public abstract class cStmtNode : cBaseAstNode
{
    public StatementNodeType Type { get; }

    protected cStmtNode(SyntaxInfo syntax, StatementNodeType type) : base(Required(syntax, nameof(syntax)))
    {
        Type = Required(type, nameof(type));
    }



}
