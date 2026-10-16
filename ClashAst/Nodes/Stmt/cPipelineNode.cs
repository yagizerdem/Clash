using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Stmt;

public sealed class cPipelineNode : cStmtNode
{
    public IReadOnlyList<cIAstNode> Commands { get; }
    public IReadOnlyList<PipeOperator> Operators { get; }

    public cPipelineNode(
        SyntaxInfo syntax,
        IReadOnlyList<cIAstNode> commands,
        IReadOnlyList<PipeOperator> operators)
        : base(syntax, StatementNodeType.Pipeline)
    {
        Commands = cStmtNode.CopyList(commands, "commands");
        Operators = cStmtNode.CopyList(operators, "operators");
    }

    public override T Accept<T>(IVisitor<T> visitor) => visitor.VisitPipeline(this);
}
