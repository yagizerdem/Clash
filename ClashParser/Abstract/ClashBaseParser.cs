namespace Clash.Parser.Abstract;

using Clash.Ast.Base;
using Clash.Parser.Implementation;

public abstract class ClashBaseParser : IClashParser {

    private string program; // stores all program

    private TreeSitter.Node tsNode;

    public ClashBaseParser(string program, TreeSitter.Node tsNode) {
        this.program = program;
        this.tsNode = tsNode;
    }

    public string GetProgram() {
        return this.program;
    }

    public TreeSitter.Node GetTsNode() {
        return this.tsNode;
    }

    public string GetProgramByOffsets() {
        return this.GetProgramByOffsets(this.tsNode);
    }

    public string GetProgramByOffsets(TreeSitter.Node tsNode) {
       if (this.IsMissing(tsNode))
        {
            throw new ArgumentException("Cannot dispatch a missing Tree-sitter node");
        }

        byte[] utf8 = System.Text.Encoding.UTF8.GetBytes(this.program);
        int start = tsNode.StartIndex;
        int end = tsNode.EndIndex;
        return System.Text.Encoding.UTF8.GetString(utf8, start, end - start);
    }

    public ClashBaseParser Dispatcher(TreeSitter.Node node)
    {
        if (this.IsMissing(node))
        {
            throw new ArgumentException("Cannot dispatch a missing Tree-sitter node");
        }

        return node.Type switch
        {
            // root
            "program" => new cProgramParse(program, node),

            // primary-expr
            "expansion" => new cExpansionParser(program, node),
            "arithmetic_expansion" => new cArithmeticExpansionParser(program, node),
            "command_substitution" => new cCommandSubstitutionParser(program, node),
            "number" => new cNumberParser(program, node),
            "simple_expansion" => new cSimpleExpansionParser(program, node),
            "string" => new cStringParser(program, node),
            "raw_string" => new cRawStringParser(program, node),
            "ansi_c_string" => new cAnsiCStringParser(program, node),
            "brace_expression" => new cBraceExpressionParser(program, node),
            "process_substitution" => new cProcessSubstitutionParser(program, node),
            "translated_string" => new cTranslatedStringParser(program, node),

            // expr
            "word" => new cWordParser(program, node),
            "binary_expression" => new cBinaryExpressionParser(program, node),
            "concatenation" => new cConcatenationParser(program, node),
            "parenthesized_expression" => new cParenthesizedExpressionParser(program, node),
            "postfix_expression" => new cPostfixExpressionParser(program, node),
            "ternary_expression" => new cTernaryExpressionParser(program, node),
            "unary_expression" => new cUnaryExpressionParser(program, node),

            // stmt
            "c_style_for_statement" => new cCStyleForStatementParser(program, node),
            "case_statement" => new cCaseStatementParser(program, node),
            "command" => new cCommandParser(program, node),
            "compound_statement" => new cCompoundStatementParser(program, node),
            "declaration_command" => new cDeclarationCommandParser(program, node),
            "for_statement" => new cForStatementParser(program, node),
            "function_definition" => new cFunctionDefinitionParser(program, node),
            "if_statement" => new cIfStatementParser(program, node),
            "list" => new cListParser(program, node),
            "negated_command" => new cNegatedCommandParser(program, node),
            "pipeline" => new cPipelineParser(program, node),
            "redirected_statement" => new cRedirectedStatementParser(program, node),
            "subshell" => new cSubshellParser(program, node),
            "test_command" => new cTestCommandParser(program, node),
            "unset_command" => new cUnsetCommandParser(program, node),
            "variable_assignment" => new cVariableAssignmentParser(program, node),
            "variable_assignments" => new cVariableAssignmentsParser(program, node),
            "while_statement" => new cWhileStatementParser(program, node),

            // other
            "array" => new cArrayParser(program, node),
            "comment" => new cCommentParser(program, node),
            "case_item" => new cCaseItemParser(program, node),
            "command_name" => new cCommandNameParser(program, node),
            "do_group" => new cDoGroupParser(program, node),
            "elif_clause" => new cElifClauseParser(program, node),
            "else_clause" => new cElseClauseParser(program, node),
            "extglob_pattern" => new cExtglobPatternParser(program, node),
            "file_descriptor" => new cFileDescriptorParser(program, node),
            "file_redirect" => new cFileRedirectParser(program, node),
            "heredoc_body" => new cHeredocBodyParser(program, node),
            "heredoc_content" => new cHeredocContentParser(program, node),
            "heredoc_end" => new cHeredocEndParser(program, node),
            "heredoc_redirect" => new cHeredocRedirectParser(program, node),
            "heredoc_start" => new cHeredocStartParser(program, node),
            "herestring_redirect" => new cHerestringRedirectParser(program, node),
            "string_content" => new cStringContentParser(program, node),
            "subscript" => new cSubscriptParser(program, node),
            "test_operator" => new cTestOperatorParser(program, node),
            "special_variable_name" => new cSpecialVariableNameParser(program, node),
            "variable_name" => new cVariableNameParser(program, node),
            "regex" => new cRegexParser(program, node),

            _ => throw new InvalidOperationException(
                $"Unknown Tree-sitter node type: {node.Type}"
            )
        };
    }


    public SyntaxInfo ExtractSyntaxInfo() {
        SourceSpan span = new SourceSpan(tsNode.StartIndex, tsNode.EndIndex);
        String text = this.GetProgramByOffsets();
        SyntaxInfo syntaxInfo = new SyntaxInfo(span, text);
        return syntaxInfo;
    }

    public SyntaxInfo ExtractSyntaxInfo(TreeSitter.Node tsNode) {
        SourceSpan span = new SourceSpan(tsNode.StartIndex, tsNode.EndIndex);
        String text = this.GetProgramByOffsets(tsNode);
        SyntaxInfo syntaxInfo = new SyntaxInfo(span, text);
        return syntaxInfo;
    }

    public void CheckType(TreeSitter.Node node, string tsTypeName) {
        if (this.IsMissing(node)) {
            throw new ArgumentException("Expected node type '" + tsTypeName + "', but node is missing");
        }

        if (!node.Type.Equals(tsTypeName)) {
            throw new ArgumentException(
                    $"Expected node type '{tsTypeName}', but got '{node.Type}'"
            );
        }
    }


    // implementation classes should provide the parsing logic for each specific node type
    public abstract IAstNode Parse(TreeSitter.Node node); 

    public bool IsMissing(TreeSitter.Node? node) {
        return node == null || node.IsMissing;
    }

    public IAstNode ParseChild(TreeSitter.Node node) {
        if (this.IsMissing(node)) {
            throw new ArgumentException("Cannot parse a missing Tree-sitter child node");
        }

        if (node.IsNamed) {
            return this.Dispatcher(node).Parse(node);
        }

        ClashBaseParser parser = this.Dispatcher(node);
        IAstNode childNode = parser.Parse(node);

        return childNode;
    }

    public List<IAstNode> CollectNamedChildren(TreeSitter.Node tsNode){
        List<IAstNode> parts = new List<IAstNode>();
        for(int i = 0; i < tsNode.NamedChildren.Count; i++) {
            TreeSitter.Node child = tsNode.NamedChildren[i];
            ClashBaseParser parser = this.Dispatcher(child);
            IAstNode cNode = parser.Parse(child);
            parts.Add(cNode);
        }
        return parts;
    }

    public List<IAstNode> CollectNamedChildren(){
        List<IAstNode> parts = new List<IAstNode>();
        for(int i = 0; i < tsNode.NamedChildren.Count; i++) {
            TreeSitter.Node child = tsNode.NamedChildren[i];
            ClashBaseParser parser = this.Dispatcher(child);
            IAstNode cNode = parser.Parse(child);
            parts.Add(cNode);
        }
        return parts;
    }

    public List<TreeSitter.Node> GetChildrenByFieldName(
            String fieldName
    ) {
        List<TreeSitter.Node> result = new List<TreeSitter.Node>();

        for (int i = 0; i < tsNode.Children.Count; i++) {
            string? currentFieldName = tsNode.GetFieldNameForChild(i);

            if (fieldName.Equals(currentFieldName)) {
                result.Add(tsNode.Children[i]);
            }
        }

        return result;
    }

    public List<TreeSitter.Node> GetChildrenByFieldName(
            TreeSitter.Node tsNode,
            string fieldName
    ) {
        List<TreeSitter.Node> result = new List<TreeSitter.Node>();

        for (int i = 0; i < tsNode.Children.Count; i++) {
            string? currentFieldName = tsNode.GetFieldNameForChild(i);

            if (fieldName.Equals(currentFieldName)) {
                result.Add(tsNode.Children[i]);
            }
        }

        return result;
    }
}
