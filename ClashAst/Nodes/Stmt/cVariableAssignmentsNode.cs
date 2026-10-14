using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Stmt;

public sealed class cVariableAssignmentsNode : cStmtNode
{
    public IReadOnlyList<cVariableAssignmentNode> Assignments { get; }

    public cVariableAssignmentsNode(
        SyntaxInfo syntax,
        IReadOnlyList<cVariableAssignmentNode> assignments)
        : base(syntax, StatementNodeType.VariableAssignments)
    {
        Assignments = cStmtNode.CopyList(assignments, "assignments");
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitVariableAssignments<T>(this);
}
