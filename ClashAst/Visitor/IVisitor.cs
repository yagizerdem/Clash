using Clash.Ast;
using Clash.Ast.Base;
using Clash.Ast.Nodes;
using Clash.Ast.Nodes.Expr;
using Clash.Ast.Nodes.Other;
using Clash.Ast.Nodes.PrimaryExpr;
using Clash.Ast.Nodes.Stmt;

namespace Clash.Ast.Visitor;

public interface IVisitor
{
    // expr
    T VisitBinaryExpression<T>(BinaryExpressionNode node);
    T VisitConcatenation<T>(ConcatenationNode node);
    T VisitParenthesizedExpression<T>(ParenthesizedExpressionNode node);
    T VisitPostfixExpression<T>(PostfixExpressionNode node);
    T VisitTernaryExpression<T>(TernaryExpressionNode node);
    T VisitUnaryExpression<T>(UnaryExpressionNode node);
    T VisitWord<T>(WordNode node);

    // primary expr
    T VisitAnsiCString<T>(AnsiCStringNode node);
    T VisitArithmeticExpansion<T>(ArithmeticExpansionNode node);
    T VisitBraceExpression<T>(BraceExpressionNode node);
    T VisitCommandSubstitution<T>(CommandSubstitutionNode node);
    T VisitExpansion<T>(ExpansionNode node);
    T VisitNumber<T>(NumberNode node);
    T VisitProcessSubstitution<T>(ProcessSubstitutionNode node);
    T VisitRawString<T>(RawStringNode node);
    T VisitSimpleExpansion<T>(SimpleExpansionNode node);
    T VisitString<T>(StringNode node);
    T VisitTranslatedString<T>(TranslatedStringNode node);

    // stmt
    T VisitCStyleForStatement<T>(CStyleForStatementNode node);
    T VisitCaseStatement<T>(CaseStatementNode node);
    T VisitCommand<T>(CommandNode node);
    T VisitCompoundStatement<T>(CompoundStatementNode node);
    T VisitDeclarationCommand<T>(DeclarationCommandNode node);
    T VisitForStatement<T>(ForStatementNode node);
    T VisitFunctionDefinition<T>(FunctionDefinitionNode node);
    T VisitIfStatement<T>(IfStatementNode node);
    T VisitList<T>(ListNode node);
    T VisitNegatedCommand<T>(NegatedCommandNode node);
    T VisitPipeline<T>(PipelineNode node);
    T VisitRedirectedStatement<T>(RedirectedStatementNode node);
    T VisitSubshell<T>(SubshellNode node);
    T VisitTestCommand<T>(TestCommandNode node);
    T VisitUnsetCommand<T>(UnsetCommandNode node);
    T VisitVariableAssignment<T>(VariableAssignmentNode node);
    T VisitVariableAssignments<T>(VariableAssignmentsNode node);
    T VisitWhileStatement<T>(WhileStatementNode node);

    // other
    T VisitArray<T>(ArrayNode node);
    T VisitCaseItem<T>(CaseItemNode node);
    T VisitCommandName<T>(CommandNameNode node);
    T VisitComment<T>(CommentNode node);
    T VisitDoGroup<T>(DoGroupNode node);
    T VisitElifClause<T>(ElifClauseNode node);
    T VisitElseClause<T>(ElseClauseNode node);
    T VisitExtglobPattern<T>(ExtglobPatternNode node);
    T VisitFileDescriptor<T>(FileDescriptorNode node);
    T VisitFileRedirect<T>(FileRedirectNode node);
    T VisitHeredocBody<T>(HeredocBodyNode node);
    T VisitHeredocContent<T>(HeredocContentNode node);
    T VisitHeredocEnd<T>(HeredocEndNode node);
    T VisitHeredocRedirect<T>(HeredocRedirectNode node);
    T VisitHeredocStart<T>(HeredocStartNode node);
    T VisitHerestringRedirect<T>(HerestringRedirectNode node);
    T VisitRegex<T>(RegexNode node);
    T VisitSpecialVariableName<T>(SpecialVariableNameNode node);
    T VisitStringContent<T>(StringContentNode node);
    T VisitSubscript<T>(SubscriptNode node);
    T VisitTestOperator<T>(TestOperatorNode node);
    T VisitVariableName<T>(VariableNameNode node);

    // root
    T VisitProgram<T>(ProgramNode node);

    // core
    T VisitConcreteBase<T>(ConcreteBaseAstNode node);
}
