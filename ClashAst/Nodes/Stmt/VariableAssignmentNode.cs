using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Stmt;

public sealed class VariableAssignmentNode : StmtNode
{
    public IAstNode Name { get; }
    public IAstNode Value { get; }

    public VariableAssignmentNode(
        SyntaxInfo syntax,
        IAstNode name,
        IAstNode value)
        : base(syntax, StatementNodeType.VariableAssignment)
    {
        Name = StmtNode.Required(name, "name");
        Value = StmtNode.Required(value, "value");
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitVariableAssignment<T>(this);
}
