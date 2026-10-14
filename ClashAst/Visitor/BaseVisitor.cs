using Clash.Ast;
using Clash.Ast.Base;
using Clash.Ast.Nodes;
using Clash.Ast.Nodes.Expr;
using Clash.Ast.Nodes.Other;
using Clash.Ast.Nodes.PrimaryExpr;
using Clash.Ast.Nodes.Stmt;

namespace Clash.Ast.Visitor;

public abstract class BaseVisitor : IVisitor
{
    private static NotSupportedException NotImplemented(string methodName) =>
        new($"{methodName} is not implemented");

    // expr
    public virtual T VisitBinaryExpression<T>(BinaryExpressionNode node) => throw NotImplemented(nameof(VisitBinaryExpression));
    public virtual T VisitConcatenation<T>(ConcatenationNode node) => throw NotImplemented(nameof(VisitConcatenation));
    public virtual T VisitParenthesizedExpression<T>(ParenthesizedExpressionNode node) => throw NotImplemented(nameof(VisitParenthesizedExpression));
    public virtual T VisitPostfixExpression<T>(PostfixExpressionNode node) => throw NotImplemented(nameof(VisitPostfixExpression));
    public virtual T VisitTernaryExpression<T>(TernaryExpressionNode node) => throw NotImplemented(nameof(VisitTernaryExpression));
    public virtual T VisitUnaryExpression<T>(UnaryExpressionNode node) => throw NotImplemented(nameof(VisitUnaryExpression));
    public virtual T VisitWord<T>(WordNode node) => throw NotImplemented(nameof(VisitWord));

    // primary expr
    public virtual T VisitAnsiCString<T>(AnsiCStringNode node) => throw NotImplemented(nameof(VisitAnsiCString));
    public virtual T VisitArithmeticExpansion<T>(ArithmeticExpansionNode node) => throw NotImplemented(nameof(VisitArithmeticExpansion));
    public virtual T VisitBraceExpression<T>(BraceExpressionNode node) => throw NotImplemented(nameof(VisitBraceExpression));
    public virtual T VisitCommandSubstitution<T>(CommandSubstitutionNode node) => throw NotImplemented(nameof(VisitCommandSubstitution));
    public virtual T VisitExpansion<T>(ExpansionNode node) => throw NotImplemented(nameof(VisitExpansion));
    public virtual T VisitNumber<T>(NumberNode node) => throw NotImplemented(nameof(VisitNumber));
    public virtual T VisitProcessSubstitution<T>(ProcessSubstitutionNode node) => throw NotImplemented(nameof(VisitProcessSubstitution));
    public virtual T VisitRawString<T>(RawStringNode node) => throw NotImplemented(nameof(VisitRawString));
    public virtual T VisitSimpleExpansion<T>(SimpleExpansionNode node) => throw NotImplemented(nameof(VisitSimpleExpansion));
    public virtual T VisitString<T>(StringNode node) => throw NotImplemented(nameof(VisitString));
    public virtual T VisitTranslatedString<T>(TranslatedStringNode node) => throw NotImplemented(nameof(VisitTranslatedString));

    // stmt
    public virtual T VisitCStyleForStatement<T>(CStyleForStatementNode node) => throw NotImplemented(nameof(VisitCStyleForStatement));
    public virtual T VisitCaseStatement<T>(CaseStatementNode node) => throw NotImplemented(nameof(VisitCaseStatement));
    public virtual T VisitCommand<T>(CommandNode node) => throw NotImplemented(nameof(VisitCommand));
    public virtual T VisitCompoundStatement<T>(CompoundStatementNode node) => throw NotImplemented(nameof(VisitCompoundStatement));
    public virtual T VisitDeclarationCommand<T>(DeclarationCommandNode node) => throw NotImplemented(nameof(VisitDeclarationCommand));
    public virtual T VisitForStatement<T>(ForStatementNode node) => throw NotImplemented(nameof(VisitForStatement));
    public virtual T VisitFunctionDefinition<T>(FunctionDefinitionNode node) => throw NotImplemented(nameof(VisitFunctionDefinition));
    public virtual T VisitIfStatement<T>(IfStatementNode node) => throw NotImplemented(nameof(VisitIfStatement));
    public virtual T VisitList<T>(ListNode node) => throw NotImplemented(nameof(VisitList));
    public virtual T VisitNegatedCommand<T>(NegatedCommandNode node) => throw NotImplemented(nameof(VisitNegatedCommand));
    public virtual T VisitPipeline<T>(PipelineNode node) => throw NotImplemented(nameof(VisitPipeline));
    public virtual T VisitRedirectedStatement<T>(RedirectedStatementNode node) => throw NotImplemented(nameof(VisitRedirectedStatement));
    public virtual T VisitSubshell<T>(SubshellNode node) => throw NotImplemented(nameof(VisitSubshell));
    public virtual T VisitTestCommand<T>(TestCommandNode node) => throw NotImplemented(nameof(VisitTestCommand));
    public virtual T VisitUnsetCommand<T>(UnsetCommandNode node) => throw NotImplemented(nameof(VisitUnsetCommand));
    public virtual T VisitVariableAssignment<T>(VariableAssignmentNode node) => throw NotImplemented(nameof(VisitVariableAssignment));
    public virtual T VisitVariableAssignments<T>(VariableAssignmentsNode node) => throw NotImplemented(nameof(VisitVariableAssignments));
    public virtual T VisitWhileStatement<T>(WhileStatementNode node) => throw NotImplemented(nameof(VisitWhileStatement));

    // other
    public virtual T VisitArray<T>(ArrayNode node) => throw NotImplemented(nameof(VisitArray));
    public virtual T VisitCaseItem<T>(CaseItemNode node) => throw NotImplemented(nameof(VisitCaseItem));
    public virtual T VisitCommandName<T>(CommandNameNode node) => throw NotImplemented(nameof(VisitCommandName));
    public virtual T VisitComment<T>(CommentNode node) => throw NotImplemented(nameof(VisitComment));
    public virtual T VisitDoGroup<T>(DoGroupNode node) => throw NotImplemented(nameof(VisitDoGroup));
    public virtual T VisitElifClause<T>(ElifClauseNode node) => throw NotImplemented(nameof(VisitElifClause));
    public virtual T VisitElseClause<T>(ElseClauseNode node) => throw NotImplemented(nameof(VisitElseClause));
    public virtual T VisitExtglobPattern<T>(ExtglobPatternNode node) => throw NotImplemented(nameof(VisitExtglobPattern));
    public virtual T VisitFileDescriptor<T>(FileDescriptorNode node) => throw NotImplemented(nameof(VisitFileDescriptor));
    public virtual T VisitFileRedirect<T>(FileRedirectNode node) => throw NotImplemented(nameof(VisitFileRedirect));
    public virtual T VisitHeredocBody<T>(HeredocBodyNode node) => throw NotImplemented(nameof(VisitHeredocBody));
    public virtual T VisitHeredocContent<T>(HeredocContentNode node) => throw NotImplemented(nameof(VisitHeredocContent));
    public virtual T VisitHeredocEnd<T>(HeredocEndNode node) => throw NotImplemented(nameof(VisitHeredocEnd));
    public virtual T VisitHeredocRedirect<T>(HeredocRedirectNode node) => throw NotImplemented(nameof(VisitHeredocRedirect));
    public virtual T VisitHeredocStart<T>(HeredocStartNode node) => throw NotImplemented(nameof(VisitHeredocStart));
    public virtual T VisitHerestringRedirect<T>(HerestringRedirectNode node) => throw NotImplemented(nameof(VisitHerestringRedirect));
    public virtual T VisitRegex<T>(RegexNode node) => throw NotImplemented(nameof(VisitRegex));
    public virtual T VisitSpecialVariableName<T>(SpecialVariableNameNode node) => throw NotImplemented(nameof(VisitSpecialVariableName));
    public virtual T VisitStringContent<T>(StringContentNode node) => throw NotImplemented(nameof(VisitStringContent));
    public virtual T VisitSubscript<T>(SubscriptNode node) => throw NotImplemented(nameof(VisitSubscript));
    public virtual T VisitTestOperator<T>(TestOperatorNode node) => throw NotImplemented(nameof(VisitTestOperator));
    public virtual T VisitVariableName<T>(VariableNameNode node) => throw NotImplemented(nameof(VisitVariableName));

    // root
    public virtual T VisitProgram<T>(ProgramNode node) => throw NotImplemented(nameof(VisitProgram));

    // core
    public virtual T VisitConcreteBase<T>(ConcreteBaseAstNode node) => throw NotImplemented(nameof(VisitConcreteBase));
}
