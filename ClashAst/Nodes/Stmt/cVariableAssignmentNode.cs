using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Stmt;

public sealed class cVariableAssignmentNode : cStmtNode
{
    public cIAstNode Name { get; }
    public cIAstNode Value { get; }

    public cVariableAssignmentNode(
        SyntaxInfo syntax,
        cIAstNode name,
        cIAstNode value)
        : base(syntax, StatementNodeType.VariableAssignment)
    {
        Name = cStmtNode.Required(name, "name");
        Value = cStmtNode.Required(value, "value");
    }

    public override T Accept<T>(IVisitor<T> visitor) => visitor.VisitVariableAssignment(this);
}
