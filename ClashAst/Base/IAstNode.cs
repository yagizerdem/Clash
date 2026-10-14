using Clash.Ast.Visitor;

namespace Clash.Ast.Base;

public interface IAstNode
{
    SyntaxInfo Syntax { get; }

    T Accept<T>(IVisitor visitor);
}
