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
    public virtual T VisitBinaryExpression<T>(cBinaryExpressionNode node) => throw NotImplemented(nameof(VisitBinaryExpression));
    public virtual T VisitConcatenation<T>(cConcatenationNode node) => throw NotImplemented(nameof(VisitConcatenation));
    public virtual T VisitParenthesizedExpression<T>(cParenthesizedExpressionNode node) => throw NotImplemented(nameof(VisitParenthesizedExpression));
    public virtual T VisitPostfixExpression<T>(cPostfixExpressionNode node) => throw NotImplemented(nameof(VisitPostfixExpression));
    public virtual T VisitTernaryExpression<T>(cTernaryExpressionNode node) => throw NotImplemented(nameof(VisitTernaryExpression));
    public virtual T VisitUnaryExpression<T>(cUnaryExpressionNode node) => throw NotImplemented(nameof(VisitUnaryExpression));
    public virtual T VisitWord<T>(cWordNode node) => throw NotImplemented(nameof(VisitWord));

    // primary expr
    public virtual T VisitAnsiCString<T>(cAnsiCStringNode node) => throw NotImplemented(nameof(VisitAnsiCString));
    public virtual T VisitArithmeticExpansion<T>(cArithmeticExpansionNode node) => throw NotImplemented(nameof(VisitArithmeticExpansion));
    public virtual T VisitBraceExpression<T>(cBraceExpressionNode node) => throw NotImplemented(nameof(VisitBraceExpression));
    public virtual T VisitCommandSubstitution<T>(cCommandSubstitutionNode node) => throw NotImplemented(nameof(VisitCommandSubstitution));
    public virtual T VisitExpansion<T>(cExpansionNode node) => throw NotImplemented(nameof(VisitExpansion));
    public virtual T VisitNumber<T>(cNumberNode node) => throw NotImplemented(nameof(VisitNumber));
    public virtual T VisitProcessSubstitution<T>(cProcessSubstitutionNode node) => throw NotImplemented(nameof(VisitProcessSubstitution));
    public virtual T VisitRawString<T>(cRawStringNode node) => throw NotImplemented(nameof(VisitRawString));
    public virtual T VisitSimpleExpansion<T>(cSimpleExpansionNode node) => throw NotImplemented(nameof(VisitSimpleExpansion));
    public virtual T VisitString<T>(cStringNode node) => throw NotImplemented(nameof(VisitString));
    public virtual T VisitTranslatedString<T>(cTranslatedStringNode node) => throw NotImplemented(nameof(VisitTranslatedString));

    // stmt
    public virtual T VisitCStyleForStatement<T>(cCStyleForStatementNode node) => throw NotImplemented(nameof(VisitCStyleForStatement));
    public virtual T VisitCaseStatement<T>(cCaseStatementNode node) => throw NotImplemented(nameof(VisitCaseStatement));
    public virtual T VisitCommand<T>(cCommandNode node) => throw NotImplemented(nameof(VisitCommand));
    public virtual T VisitCompoundStatement<T>(cCompoundStatementNode node) => throw NotImplemented(nameof(VisitCompoundStatement));
    public virtual T VisitDeclarationCommand<T>(cDeclarationCommandNode node) => throw NotImplemented(nameof(VisitDeclarationCommand));
    public virtual T VisitForStatement<T>(cForStatementNode node) => throw NotImplemented(nameof(VisitForStatement));
    public virtual T VisitFunctionDefinition<T>(cFunctionDefinitionNode node) => throw NotImplemented(nameof(VisitFunctionDefinition));
    public virtual T VisitIfStatement<T>(cIfStatementNode node) => throw NotImplemented(nameof(VisitIfStatement));
    public virtual T VisitList<T>(cListNode node) => throw NotImplemented(nameof(VisitList));
    public virtual T VisitNegatedCommand<T>(cNegatedCommandNode node) => throw NotImplemented(nameof(VisitNegatedCommand));
    public virtual T VisitPipeline<T>(cPipelineNode node) => throw NotImplemented(nameof(VisitPipeline));
    public virtual T VisitRedirectedStatement<T>(cRedirectedStatementNode node) => throw NotImplemented(nameof(VisitRedirectedStatement));
    public virtual T VisitSubshell<T>(cSubshellNode node) => throw NotImplemented(nameof(VisitSubshell));
    public virtual T VisitTestCommand<T>(cTestCommandNode node) => throw NotImplemented(nameof(VisitTestCommand));
    public virtual T VisitUnsetCommand<T>(cUnsetCommandNode node) => throw NotImplemented(nameof(VisitUnsetCommand));
    public virtual T VisitVariableAssignment<T>(cVariableAssignmentNode node) => throw NotImplemented(nameof(VisitVariableAssignment));
    public virtual T VisitVariableAssignments<T>(cVariableAssignmentsNode node) => throw NotImplemented(nameof(VisitVariableAssignments));
    public virtual T VisitWhileStatement<T>(cWhileStatementNode node) => throw NotImplemented(nameof(VisitWhileStatement));

    // other
    public virtual T VisitArray<T>(cArrayNode node) => throw NotImplemented(nameof(VisitArray));
    public virtual T VisitCaseItem<T>(cCaseItemNode node) => throw NotImplemented(nameof(VisitCaseItem));
    public virtual T VisitCommandName<T>(cCommandNameNode node) => throw NotImplemented(nameof(VisitCommandName));
    public virtual T VisitComment<T>(cCommentNode node) => throw NotImplemented(nameof(VisitComment));
    public virtual T VisitDoGroup<T>(cDoGroupNode node) => throw NotImplemented(nameof(VisitDoGroup));
    public virtual T VisitElifClause<T>(cElifClauseNode node) => throw NotImplemented(nameof(VisitElifClause));
    public virtual T VisitElseClause<T>(cElseClauseNode node) => throw NotImplemented(nameof(VisitElseClause));
    public virtual T VisitExtglobPattern<T>(cExtglobPatternNode node) => throw NotImplemented(nameof(VisitExtglobPattern));
    public virtual T VisitFileDescriptor<T>(cFileDescriptorNode node) => throw NotImplemented(nameof(VisitFileDescriptor));
    public virtual T VisitFileRedirect<T>(cFileRedirectNode node) => throw NotImplemented(nameof(VisitFileRedirect));
    public virtual T VisitHeredocBody<T>(cHeredocBodyNode node) => throw NotImplemented(nameof(VisitHeredocBody));
    public virtual T VisitHeredocContent<T>(cHeredocContentNode node) => throw NotImplemented(nameof(VisitHeredocContent));
    public virtual T VisitHeredocEnd<T>(cHeredocEndNode node) => throw NotImplemented(nameof(VisitHeredocEnd));
    public virtual T VisitHeredocRedirect<T>(cHeredocRedirectNode node) => throw NotImplemented(nameof(VisitHeredocRedirect));
    public virtual T VisitHeredocStart<T>(cHeredocStartNode node) => throw NotImplemented(nameof(VisitHeredocStart));
    public virtual T VisitHerestringRedirect<T>(cHerestringRedirectNode node) => throw NotImplemented(nameof(VisitHerestringRedirect));
    public virtual T VisitRegex<T>(cRegexNode node) => throw NotImplemented(nameof(VisitRegex));
    public virtual T VisitSpecialVariableName<T>(cSpecialVariableNameNode node) => throw NotImplemented(nameof(VisitSpecialVariableName));
    public virtual T VisitStringContent<T>(cStringContentNode node) => throw NotImplemented(nameof(VisitStringContent));
    public virtual T VisitSubscript<T>(cSubscriptNode node) => throw NotImplemented(nameof(VisitSubscript));
    public virtual T VisitTestOperator<T>(cTestOperatorNode node) => throw NotImplemented(nameof(VisitTestOperator));
    public virtual T VisitVariableName<T>(cVariableNameNode node) => throw NotImplemented(nameof(VisitVariableName));

    // root
    public virtual T VisitProgram<T>(cProgramNode node) => throw NotImplemented(nameof(VisitProgram));

    // core
    public virtual T VisitConcreteBase<T>(cConcreteBaseAstNode node) => throw NotImplemented(nameof(VisitConcreteBase));
}
