using Clash.Ast.Base;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes;

public sealed class ProgramNode : IAstNode
{
    public IReadOnlyList<IAstNode> Statements { get; }
    public SyntaxInfo Syntax { get; }

    public ProgramNode(SyntaxInfo syntax, IReadOnlyList<IAstNode> statements)
    {
        Statements = statements;
        Syntax = syntax;
    }

    public T Accept<T>(IVisitor visitor) => visitor.VisitProgram<T>(this);
}
