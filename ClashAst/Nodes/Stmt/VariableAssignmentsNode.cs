using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Stmt;

public sealed class VariableAssignmentsNode : StmtNode
{
    public IReadOnlyList<VariableAssignmentNode> Assignments { get; }

    public VariableAssignmentsNode(
        SyntaxInfo syntax,
        IReadOnlyList<VariableAssignmentNode> assignments)
        : base(syntax, StatementNodeType.VariableAssignments)
    {
        Assignments = StmtNode.CopyList(assignments, "assignments");
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitVariableAssignments<T>(this);
}
