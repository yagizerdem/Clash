using System.Collections.Frozen;

namespace Clash.Ast.Enums;

public enum DeclarationKind
{
    Declare,
    Export,
    Local,
    Readonly,
    Typeset
}

public enum ListOperator
{
    Sequence,
    Background,
    LogicalAnd,
    LogicalOr
}

public enum LoopKind
{
    While,
    Until
}

public enum PipeOperator
{
    Pipe,
    PipeStderr
}

public enum ProcessSubstitutionKind
{
    Input,
    Output
}

public enum RedirectionKind
{
    Input,
    InputDuplicate,
    InputClose,
    Heredoc,
    HeredocStripTabs,
    Herestring,
    Output,
    OutputDuplicate,
    OutputClose,
    OutputAppend,
    OutputClobber,
    StdoutStderr,
    StdoutStderrAppend
}

public static class RedirectionKindExtensions
{
    public static string Symbol(this RedirectionKind kind) => kind switch
    {
        RedirectionKind.Input => "<",
        RedirectionKind.InputDuplicate => "<&",
        RedirectionKind.InputClose => "<&-",
        RedirectionKind.Heredoc => "<<",
        RedirectionKind.HeredocStripTabs => "<<-",
        RedirectionKind.Herestring => "<<<",
        RedirectionKind.Output => ">",
        RedirectionKind.OutputDuplicate => ">&",
        RedirectionKind.OutputClose => ">&-",
        RedirectionKind.OutputAppend => ">>",
        RedirectionKind.OutputClobber => ">|",
        RedirectionKind.StdoutStderr => "&>",
        RedirectionKind.StdoutStderrAppend => "&>>",
        _ => throw new ArgumentOutOfRangeException(nameof(kind), kind, null)
    };

    public static RedirectionKind FromSymbol(string symbol) => symbol switch
    {
        "<" => RedirectionKind.Input,
        "<&" => RedirectionKind.InputDuplicate,
        "<&-" => RedirectionKind.InputClose,
        "<<" => RedirectionKind.Heredoc,
        "<<-" => RedirectionKind.HeredocStripTabs,
        "<<<" => RedirectionKind.Herestring,
        ">" => RedirectionKind.Output,
        ">&" => RedirectionKind.OutputDuplicate,
        ">&-" => RedirectionKind.OutputClose,
        ">>" => RedirectionKind.OutputAppend,
        ">|" => RedirectionKind.OutputClobber,
        "&>" => RedirectionKind.StdoutStderr,
        "&>>" => RedirectionKind.StdoutStderrAppend,
        _ => throw new ArgumentException($"Unknown redirection operator: {symbol}", nameof(symbol))
    };
}

public enum ExpressionNodeType
{
    BinaryExpression,
    Concatenation,
    ParenthesizedExpression,
    PostfixExpression,
    TernaryExpression,
    UnaryExpression,
    AnsiCString,
    ArithmeticExpansion,
    BraceExpression,
    CommandSubstitution,
    Expansion,
    Number,
    ProcessSubstitution,
    RawString,
    SimpleExpansion,
    String,
    TranslatedString,
    Word
}

public static class ExpressionNodeTypeExtensions
{
    private static readonly FrozenDictionary<string, ExpressionNodeType> ByTreeSitterType =
        Enum.GetValues<ExpressionNodeType>().ToFrozenDictionary(type => type.TreeSitterType());

    public static string TreeSitterType(this ExpressionNodeType type) => type switch
    {
        ExpressionNodeType.BinaryExpression => "binary_expression",
        ExpressionNodeType.Concatenation => "concatenation",
        ExpressionNodeType.ParenthesizedExpression => "parenthesized_expression",
        ExpressionNodeType.PostfixExpression => "postfix_expression",
        ExpressionNodeType.TernaryExpression => "ternary_expression",
        ExpressionNodeType.UnaryExpression => "unary_expression",
        ExpressionNodeType.AnsiCString => "ansi_c_string",
        ExpressionNodeType.ArithmeticExpansion => "arithmetic_expansion",
        ExpressionNodeType.BraceExpression => "brace_expression",
        ExpressionNodeType.CommandSubstitution => "command_substitution",
        ExpressionNodeType.Expansion => "expansion",
        ExpressionNodeType.Number => "number",
        ExpressionNodeType.ProcessSubstitution => "process_substitution",
        ExpressionNodeType.RawString => "raw_string",
        ExpressionNodeType.SimpleExpansion => "simple_expansion",
        ExpressionNodeType.String => "string",
        ExpressionNodeType.TranslatedString => "translated_string",
        ExpressionNodeType.Word => "word",
        _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
    };

    public static bool IsPrimary(this ExpressionNodeType type) => type switch
    {
        ExpressionNodeType.AnsiCString or
        ExpressionNodeType.ArithmeticExpansion or
        ExpressionNodeType.BraceExpression or
        ExpressionNodeType.CommandSubstitution or
        ExpressionNodeType.Expansion or
        ExpressionNodeType.Number or
        ExpressionNodeType.ProcessSubstitution or
        ExpressionNodeType.RawString or
        ExpressionNodeType.SimpleExpansion or
        ExpressionNodeType.String or
        ExpressionNodeType.TranslatedString or
        ExpressionNodeType.Word => true,
        _ => false
    };

    public static ExpressionNodeType? FromTreeSitterType(string type) =>
        ByTreeSitterType.TryGetValue(type, out var result) ? result : null;
}

public enum StatementNodeType
{
    CStyleForStatement,
    CaseStatement,
    Command,
    CompoundStatement,
    DeclarationCommand,
    ForStatement,
    FunctionDefinition,
    IfStatement,
    List,
    NegatedCommand,
    Pipeline,
    RedirectedStatement,
    Subshell,
    TestCommand,
    UnsetCommand,
    VariableAssignment,
    VariableAssignments,
    WhileStatement
}

public static class StatementNodeTypeExtensions
{
    private static readonly FrozenDictionary<string, StatementNodeType> ByTreeSitterType =
        Enum.GetValues<StatementNodeType>().ToFrozenDictionary(type => type.TreeSitterType());

    public static string TreeSitterType(this StatementNodeType type) => type switch
    {
        StatementNodeType.CStyleForStatement => "c_style_for_statement",
        StatementNodeType.CaseStatement => "case_statement",
        StatementNodeType.Command => "command",
        StatementNodeType.CompoundStatement => "compound_statement",
        StatementNodeType.DeclarationCommand => "declaration_command",
        StatementNodeType.ForStatement => "for_statement",
        StatementNodeType.FunctionDefinition => "function_definition",
        StatementNodeType.IfStatement => "if_statement",
        StatementNodeType.List => "list",
        StatementNodeType.NegatedCommand => "negated_command",
        StatementNodeType.Pipeline => "pipeline",
        StatementNodeType.RedirectedStatement => "redirected_statement",
        StatementNodeType.Subshell => "subshell",
        StatementNodeType.TestCommand => "test_command",
        StatementNodeType.UnsetCommand => "unset_command",
        StatementNodeType.VariableAssignment => "variable_assignment",
        StatementNodeType.VariableAssignments => "variable_assignments",
        StatementNodeType.WhileStatement => "while_statement",
        _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
    };

    public static StatementNodeType? FromTreeSitterType(string type) =>
        ByTreeSitterType.TryGetValue(type, out var result) ? result : null;
}


