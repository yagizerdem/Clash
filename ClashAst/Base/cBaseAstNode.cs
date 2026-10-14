using Clash.Ast.Visitor;

namespace Clash.Ast.Base;

public abstract class cBaseAstNode : cIAstNode
{

    public SyntaxInfo Syntax { get; }

    public cBaseAstNode(SyntaxInfo syntax)
    {
        Syntax = Required(syntax, nameof(syntax));
    }

    // used for visitor pattern to implement application logic
    public abstract T Accept<T>(IVisitor visitor);


    // utility methods
    public static T Required<T>(T value, string name) =>
        value ?? throw new ArgumentNullException(name);

    public static SyntaxInfo RequireSyntax(SyntaxInfo syntax) =>
        syntax ?? throw new ArgumentNullException(nameof(syntax));

    public static IReadOnlyList<T> CopyList<T>(IEnumerable<T> values, string name) =>
        new List<T>(Required(values, name)).AsReadOnly();
}
