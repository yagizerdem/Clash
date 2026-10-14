namespace Clash.Ast.Base;

public sealed record SyntaxInfo
{
    public SourceSpan Span { get; }
    public string Raw { get; }

    public SyntaxInfo(SourceSpan span, string raw)
    {
        ArgumentNullException.ThrowIfNull(span);
        ArgumentNullException.ThrowIfNull(raw);

        Span = span;
        Raw = raw;
    }
}
