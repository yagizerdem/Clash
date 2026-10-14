namespace Clash.Ast.Base;

public sealed record SourceSpan
{
    public int StartByte { get; }
    public int EndByte { get; }

    public SourceSpan(int startByte, int endByte)
    {
        if (startByte < 0 || endByte < startByte)
        {
            throw new ArgumentException($"Invalid span: {startByte}..{endByte}");
        }

        StartByte = startByte;
        EndByte = endByte;
    }
}
