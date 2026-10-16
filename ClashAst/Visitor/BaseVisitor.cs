using Clash.Ast;
using Clash.Ast.Base;
using Clash.Ast.Nodes;
using Clash.Ast.Nodes.Expr;
using Clash.Ast.Nodes.Other;
using Clash.Ast.Nodes.PrimaryExpr;
using Clash.Ast.Nodes.Stmt;

namespace Clash.Ast.Visitor;

public abstract class BaseVisitor<T> : IVisitor<T>
{
    private static NotSupportedException NotImplemented(string methodName) =>
        new($"{methodName} is not implemented");

    // expr
    public virtual T VisitBinaryExpression(cBinaryExpressionNode node) => throw NotImplemented(nameof(VisitBinaryExpression));
    public virtual T VisitConcatenation(cConcatenationNode node) => throw NotImplemented(nameof(VisitConcatenation));
    public virtual T VisitParenthesizedExpression(cParenthesizedExpressionNode node) => throw NotImplemented(nameof(VisitParenthesizedExpression));
    public virtual T VisitPostfixExpression(cPostfixExpressionNode node) => throw NotImplemented(nameof(VisitPostfixExpression));
    public virtual T VisitTernaryExpression(cTernaryExpressionNode node) => throw NotImplemented(nameof(VisitTernaryExpression));
    public virtual T VisitUnaryExpression(cUnaryExpressionNode node) => throw NotImplemented(nameof(VisitUnaryExpression));
    public virtual T VisitWord(cWordNode node) => throw NotImplemented(nameof(VisitWord));

    // primary expr
    public virtual T VisitAnsiCString(cAnsiCStringNode node) => throw NotImplemented(nameof(VisitAnsiCString));
    public virtual T VisitArithmeticExpansion(cArithmeticExpansionNode node) => throw NotImplemented(nameof(VisitArithmeticExpansion));
    public virtual T VisitBraceExpression(cBraceExpressionNode node) => throw NotImplemented(nameof(VisitBraceExpression));
    public virtual T VisitCommandSubstitution(cCommandSubstitutionNode node) => throw NotImplemented(nameof(VisitCommandSubstitution));
    public virtual T VisitExpansion(cExpansionNode node) => throw NotImplemented(nameof(VisitExpansion));
    public virtual T VisitNumber(cNumberNode node) => throw NotImplemented(nameof(VisitNumber));
    public virtual T VisitProcessSubstitution(cProcessSubstitutionNode node) => throw NotImplemented(nameof(VisitProcessSubstitution));
    public virtual T VisitRawString(cRawStringNode node) => throw NotImplemented(nameof(VisitRawString));
    public virtual T VisitSimpleExpansion(cSimpleExpansionNode node) => throw NotImplemented(nameof(VisitSimpleExpansion));
    public virtual T VisitString(cStringNode node) => throw NotImplemented(nameof(VisitString));
    public virtual T VisitTranslatedString(cTranslatedStringNode node) => throw NotImplemented(nameof(VisitTranslatedString));

    // stmt
    public virtual T VisitCStyleForStatement(cCStyleForStatementNode node) => throw NotImplemented(nameof(VisitCStyleForStatement));
    public virtual T VisitCaseStatement(cCaseStatementNode node) => throw NotImplemented(nameof(VisitCaseStatement));
    public virtual T VisitCommand(cCommandNode node) => throw NotImplemented(nameof(VisitCommand));
    public virtual T VisitCompoundStatement(cCompoundStatementNode node) => throw NotImplemented(nameof(VisitCompoundStatement));
    public virtual T VisitDeclarationCommand(cDeclarationCommandNode node) => throw NotImplemented(nameof(VisitDeclarationCommand));
    public virtual T VisitForStatement(cForStatementNode node) => throw NotImplemented(nameof(VisitForStatement));
    public virtual T VisitFunctionDefinition(cFunctionDefinitionNode node) => throw NotImplemented(nameof(VisitFunctionDefinition));
    public virtual T VisitIfStatement(cIfStatementNode node) => throw NotImplemented(nameof(VisitIfStatement));
    public virtual T VisitList(cListNode node) => throw NotImplemented(nameof(VisitList));
    public virtual T VisitNegatedCommand(cNegatedCommandNode node) => throw NotImplemented(nameof(VisitNegatedCommand));
    public virtual T VisitPipeline(cPipelineNode node) => throw NotImplemented(nameof(VisitPipeline));
    public virtual T VisitRedirectedStatement(cRedirectedStatementNode node) => throw NotImplemented(nameof(VisitRedirectedStatement));
    public virtual T VisitSubshell(cSubshellNode node) => throw NotImplemented(nameof(VisitSubshell));
    public virtual T VisitTestCommand(cTestCommandNode node) => throw NotImplemented(nameof(VisitTestCommand));
    public virtual T VisitUnsetCommand(cUnsetCommandNode node) => throw NotImplemented(nameof(VisitUnsetCommand));
    public virtual T VisitVariableAssignment(cVariableAssignmentNode node) => throw NotImplemented(nameof(VisitVariableAssignment));
    public virtual T VisitVariableAssignments(cVariableAssignmentsNode node) => throw NotImplemented(nameof(VisitVariableAssignments));
    public virtual T VisitWhileStatement(cWhileStatementNode node) => throw NotImplemented(nameof(VisitWhileStatement));

    // other
    public virtual T VisitArray(cArrayNode node) => throw NotImplemented(nameof(VisitArray));
    public virtual T VisitCaseItem(cCaseItemNode node) => throw NotImplemented(nameof(VisitCaseItem));
    public virtual T VisitCommandName(cCommandNameNode node) => throw NotImplemented(nameof(VisitCommandName));
    public virtual T VisitComment(cCommentNode node) => throw NotImplemented(nameof(VisitComment));
    public virtual T VisitDoGroup(cDoGroupNode node) => throw NotImplemented(nameof(VisitDoGroup));
    public virtual T VisitElifClause(cElifClauseNode node) => throw NotImplemented(nameof(VisitElifClause));
    public virtual T VisitElseClause(cElseClauseNode node) => throw NotImplemented(nameof(VisitElseClause));
    public virtual T VisitExtglobPattern(cExtglobPatternNode node) => throw NotImplemented(nameof(VisitExtglobPattern));
    public virtual T VisitFileDescriptor(cFileDescriptorNode node) => throw NotImplemented(nameof(VisitFileDescriptor));
    public virtual T VisitFileRedirect(cFileRedirectNode node) => throw NotImplemented(nameof(VisitFileRedirect));
    public virtual T VisitHeredocBody(cHeredocBodyNode node) => throw NotImplemented(nameof(VisitHeredocBody));
    public virtual T VisitHeredocContent(cHeredocContentNode node) => throw NotImplemented(nameof(VisitHeredocContent));
    public virtual T VisitHeredocEnd(cHeredocEndNode node) => throw NotImplemented(nameof(VisitHeredocEnd));
    public virtual T VisitHeredocRedirect(cHeredocRedirectNode node) => throw NotImplemented(nameof(VisitHeredocRedirect));
    public virtual T VisitHeredocStart(cHeredocStartNode node) => throw NotImplemented(nameof(VisitHeredocStart));
    public virtual T VisitHerestringRedirect(cHerestringRedirectNode node) => throw NotImplemented(nameof(VisitHerestringRedirect));
    public virtual T VisitRegex(cRegexNode node) => throw NotImplemented(nameof(VisitRegex));
    public virtual T VisitSpecialVariableName(cSpecialVariableNameNode node) => throw NotImplemented(nameof(VisitSpecialVariableName));
    public virtual T VisitStringContent(cStringContentNode node) => throw NotImplemented(nameof(VisitStringContent));
    public virtual T VisitSubscript(cSubscriptNode node) => throw NotImplemented(nameof(VisitSubscript));
    public virtual T VisitTestOperator(cTestOperatorNode node) => throw NotImplemented(nameof(VisitTestOperator));
    public virtual T VisitVariableName(cVariableNameNode node) => throw NotImplemented(nameof(VisitVariableName));

    // root
    public virtual T VisitProgram(cProgramNode node) => throw NotImplemented(nameof(VisitProgram));

    // core
    public virtual T VisitConcreteBase(cConcreteBaseAstNode node) => throw NotImplemented(nameof(VisitConcreteBase));
}

public abstract class ConcreateBaseAstVisitor<T> : BaseVisitor<T>
{
    // expr
    public override T VisitBinaryExpression(cBinaryExpressionNode node) => default!;
    public override T VisitConcatenation(cConcatenationNode node) => default!;
    public override T VisitParenthesizedExpression(cParenthesizedExpressionNode node) => default!;
    public override T VisitPostfixExpression(cPostfixExpressionNode node) => default!;
    public override T VisitTernaryExpression(cTernaryExpressionNode node) => default!;
    public override T VisitUnaryExpression(cUnaryExpressionNode node) => default!;
    public override T VisitWord(cWordNode node) => default!;

    // primary expr
    public override T VisitAnsiCString(cAnsiCStringNode node) => default!;
    public override T VisitArithmeticExpansion(cArithmeticExpansionNode node) => default!;
    public override T VisitBraceExpression(cBraceExpressionNode node) => default!;
    public override T VisitCommandSubstitution(cCommandSubstitutionNode node) => default!;
    public override T VisitExpansion(cExpansionNode node) => default!;
    public override T VisitNumber(cNumberNode node) => default!;
    public override T VisitProcessSubstitution(cProcessSubstitutionNode node) => default!;
    public override T VisitRawString(cRawStringNode node) => default!;
    public override T VisitSimpleExpansion(cSimpleExpansionNode node) => default!;
    public override T VisitString(cStringNode node) => default!;
    public override T VisitTranslatedString(cTranslatedStringNode node) => default!;

    // stmt
    public override T VisitCStyleForStatement(cCStyleForStatementNode node) => default!;
    public override T VisitCaseStatement(cCaseStatementNode node) => default!;
    public override T VisitCommand(cCommandNode node) => default!;
    public override T VisitCompoundStatement(cCompoundStatementNode node) => default!;
    public override T VisitDeclarationCommand(cDeclarationCommandNode node) => default!;
    public override T VisitForStatement(cForStatementNode node) => default!;
    public override T VisitFunctionDefinition(cFunctionDefinitionNode node) => default!;
    public override T VisitIfStatement(cIfStatementNode node) => default!;
    public override T VisitList(cListNode node) => default!;
    public override T VisitNegatedCommand(cNegatedCommandNode node) => default!;
    public override T VisitPipeline(cPipelineNode node) => default!;
    public override T VisitRedirectedStatement(cRedirectedStatementNode node) => default!;
    public override T VisitSubshell(cSubshellNode node) => default!;
    public override T VisitTestCommand(cTestCommandNode node) => default!;
    public override T VisitUnsetCommand(cUnsetCommandNode node) => default!;
    public override T VisitVariableAssignment(cVariableAssignmentNode node) => default!;
    public override T VisitVariableAssignments(cVariableAssignmentsNode node) => default!;
    public override T VisitWhileStatement(cWhileStatementNode node) => default!;

    // other
    public override T VisitArray(cArrayNode node) => default!;
    public override T VisitCaseItem(cCaseItemNode node) => default!;
    public override T VisitCommandName(cCommandNameNode node) => default!;
    public override T VisitComment(cCommentNode node) => default!;
    public override T VisitDoGroup(cDoGroupNode node) => default!;
    public override T VisitElifClause(cElifClauseNode node) => default!;
    public override T VisitElseClause(cElseClauseNode node) => default!;
    public override T VisitExtglobPattern(cExtglobPatternNode node) => default!;
    public override T VisitFileDescriptor(cFileDescriptorNode node) => default!;
    public override T VisitFileRedirect(cFileRedirectNode node) => default!;
    public override T VisitHeredocBody(cHeredocBodyNode node) => default!;
    public override T VisitHeredocContent(cHeredocContentNode node) => default!;
    public override T VisitHeredocEnd(cHeredocEndNode node) => default!;
    public override T VisitHeredocRedirect(cHeredocRedirectNode node) => default!;
    public override T VisitHeredocStart(cHeredocStartNode node) => default!;
    public override T VisitHerestringRedirect(cHerestringRedirectNode node) => default!;
    public override T VisitRegex(cRegexNode node) => default!;
    public override T VisitSpecialVariableName(cSpecialVariableNameNode node) => default!;
    public override T VisitStringContent(cStringContentNode node) => default!;
    public override T VisitSubscript(cSubscriptNode node) => default!;
    public override T VisitTestOperator(cTestOperatorNode node) => default!;
    public override T VisitVariableName(cVariableNameNode node) => default!;

    // root
    public override T VisitProgram(cProgramNode node) => default!;

    // core
    public override T VisitConcreteBase(cConcreteBaseAstNode node) => default!;
}