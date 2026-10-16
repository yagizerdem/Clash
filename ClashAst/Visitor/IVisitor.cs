using Clash.Ast;
using Clash.Ast.Base;
using Clash.Ast.Nodes;
using Clash.Ast.Nodes.Expr;
using Clash.Ast.Nodes.Other;
using Clash.Ast.Nodes.PrimaryExpr;
using Clash.Ast.Nodes.Stmt;

namespace Clash.Ast.Visitor;

public interface IVisitor<T>
{
    // expr
    T VisitBinaryExpression(cBinaryExpressionNode node);
    T VisitConcatenation(cConcatenationNode node);
    T VisitParenthesizedExpression(cParenthesizedExpressionNode node);
    T VisitPostfixExpression(cPostfixExpressionNode node);
    T VisitTernaryExpression(cTernaryExpressionNode node);
    T VisitUnaryExpression(cUnaryExpressionNode node);
    T VisitWord(cWordNode node);

    // primary expr
    T VisitAnsiCString(cAnsiCStringNode node);
    T VisitArithmeticExpansion(cArithmeticExpansionNode node);
    T VisitBraceExpression(cBraceExpressionNode node);
    T VisitCommandSubstitution(cCommandSubstitutionNode node);
    T VisitExpansion(cExpansionNode node);
    T VisitNumber(cNumberNode node);
    T VisitProcessSubstitution(cProcessSubstitutionNode node);
    T VisitRawString(cRawStringNode node);
    T VisitSimpleExpansion(cSimpleExpansionNode node);
    T VisitString(cStringNode node);
    T VisitTranslatedString(cTranslatedStringNode node);

    // stmt
    T VisitCStyleForStatement(cCStyleForStatementNode node);
    T VisitCaseStatement(cCaseStatementNode node);
    T VisitCommand(cCommandNode node);
    T VisitCompoundStatement(cCompoundStatementNode node);
    T VisitDeclarationCommand(cDeclarationCommandNode node);
    T VisitForStatement(cForStatementNode node);
    T VisitFunctionDefinition(cFunctionDefinitionNode node);
    T VisitIfStatement(cIfStatementNode node);
    T VisitList(cListNode node);
    T VisitNegatedCommand(cNegatedCommandNode node);
    T VisitPipeline(cPipelineNode node);
    T VisitRedirectedStatement(cRedirectedStatementNode node);
    T VisitSubshell(cSubshellNode node);
    T VisitTestCommand(cTestCommandNode node);
    T VisitUnsetCommand(cUnsetCommandNode node);
    T VisitVariableAssignment(cVariableAssignmentNode node);
    T VisitVariableAssignments(cVariableAssignmentsNode node);
    T VisitWhileStatement(cWhileStatementNode node);

    // other
    T VisitArray(cArrayNode node);
    T VisitCaseItem(cCaseItemNode node);
    T VisitCommandName(cCommandNameNode node);
    T VisitComment(cCommentNode node);
    T VisitDoGroup(cDoGroupNode node);
    T VisitElifClause(cElifClauseNode node);
    T VisitElseClause(cElseClauseNode node);
    T VisitExtglobPattern(cExtglobPatternNode node);
    T VisitFileDescriptor(cFileDescriptorNode node);
    T VisitFileRedirect(cFileRedirectNode node);
    T VisitHeredocBody(cHeredocBodyNode node);
    T VisitHeredocContent(cHeredocContentNode node);
    T VisitHeredocEnd(cHeredocEndNode node);
    T VisitHeredocRedirect(cHeredocRedirectNode node);
    T VisitHeredocStart(cHeredocStartNode node);
    T VisitHerestringRedirect(cHerestringRedirectNode node);
    T VisitRegex(cRegexNode node);
    T VisitSpecialVariableName(cSpecialVariableNameNode node);
    T VisitStringContent(cStringContentNode node);
    T VisitSubscript(cSubscriptNode node);
    T VisitTestOperator(cTestOperatorNode node);
    T VisitVariableName(cVariableNameNode node);

    // root
    T VisitProgram(cProgramNode node);

    // core
    T VisitConcreteBase(cConcreteBaseAstNode node);
}
