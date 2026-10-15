using Clash.Ast.Base;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes;

public sealed class cProgramNode : cIAstNode
{
    public IReadOnlyList<cIAstNode> Statements { get; }
    public SyntaxInfo Syntax { get; }

    public cProgramNode(SyntaxInfo syntax, IReadOnlyList<cIAstNode> statements)
    {
        Statements = statements;
        Syntax = syntax;
    }

    public T Accept<T>(IVisitor visitor) => visitor.VisitProgram<T>(this);
}
