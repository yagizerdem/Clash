using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Stmt;

public sealed class PipelineNode : StmtNode
{
    public IReadOnlyList<IAstNode> Commands { get; }
    public IReadOnlyList<PipeOperator> Operators { get; }

    public PipelineNode(
        SyntaxInfo syntax,
        IReadOnlyList<IAstNode> commands,
        IReadOnlyList<PipeOperator> operators)
        : base(syntax, StatementNodeType.Pipeline)
    {
        Commands = StmtNode.CopyList(commands, "commands");
        Operators = StmtNode.CopyList(operators, "operators");
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitPipeline<T>(this);
}
