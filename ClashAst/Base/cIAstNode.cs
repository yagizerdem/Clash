using Clash.Ast.Visitor;

namespace Clash.Ast.Base;

public interface cIAstNode
{
    SyntaxInfo Syntax { get; }

    T Accept<T>(IVisitor<T> visitor);
}
