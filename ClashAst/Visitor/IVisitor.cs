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
    T VisitBinaryExpression<T>(cBinaryExpressionNode node);
    T VisitConcatenation<T>(cConcatenationNode node);
    T VisitParenthesizedExpression<T>(cParenthesizedExpressionNode node);
    T VisitPostfixExpression<T>(cPostfixExpressionNode node);
    T VisitTernaryExpression<T>(cTernaryExpressionNode node);
    T VisitUnaryExpression<T>(cUnaryExpressionNode node);
    T VisitWord<T>(cWordNode node);

    // primary expr
    T VisitAnsiCString<T>(cAnsiCStringNode node);
    T VisitArithmeticExpansion<T>(cArithmeticExpansionNode node);
    T VisitBraceExpression<T>(cBraceExpressionNode node);
    T VisitCommandSubstitution<T>(cCommandSubstitutionNode node);
    T VisitExpansion<T>(cExpansionNode node);
    T VisitNumber<T>(cNumberNode node);
    T VisitProcessSubstitution<T>(cProcessSubstitutionNode node);
    T VisitRawString<T>(cRawStringNode node);
    T VisitSimpleExpansion<T>(cSimpleExpansionNode node);
    T VisitString<T>(cStringNode node);
    T VisitTranslatedString<T>(cTranslatedStringNode node);

    // stmt
    T VisitCStyleForStatement<T>(cCStyleForStatementNode node);
    T VisitCaseStatement<T>(cCaseStatementNode node);
    T VisitCommand<T>(cCommandNode node);
    T VisitCompoundStatement<T>(cCompoundStatementNode node);
    T VisitDeclarationCommand<T>(cDeclarationCommandNode node);
    T VisitForStatement<T>(cForStatementNode node);
    T VisitFunctionDefinition<T>(cFunctionDefinitionNode node);
    T VisitIfStatement<T>(cIfStatementNode node);
    T VisitList<T>(cListNode node);
    T VisitNegatedCommand<T>(cNegatedCommandNode node);
    T VisitPipeline<T>(cPipelineNode node);
    T VisitRedirectedStatement<T>(cRedirectedStatementNode node);
    T VisitSubshell<T>(cSubshellNode node);
    T VisitTestCommand<T>(cTestCommandNode node);
    T VisitUnsetCommand<T>(cUnsetCommandNode node);
    T VisitVariableAssignment<T>(cVariableAssignmentNode node);
    T VisitVariableAssignments<T>(cVariableAssignmentsNode node);
    T VisitWhileStatement<T>(cWhileStatementNode node);

    // other
    T VisitArray<T>(cArrayNode node);
    T VisitCaseItem<T>(cCaseItemNode node);
    T VisitCommandName<T>(cCommandNameNode node);
    T VisitComment<T>(cCommentNode node);
    T VisitDoGroup<T>(cDoGroupNode node);
    T VisitElifClause<T>(cElifClauseNode node);
    T VisitElseClause<T>(cElseClauseNode node);
    T VisitExtglobPattern<T>(cExtglobPatternNode node);
    T VisitFileDescriptor<T>(cFileDescriptorNode node);
    T VisitFileRedirect<T>(cFileRedirectNode node);
    T VisitHeredocBody<T>(cHeredocBodyNode node);
    T VisitHeredocContent<T>(cHeredocContentNode node);
    T VisitHeredocEnd<T>(cHeredocEndNode node);
    T VisitHeredocRedirect<T>(cHeredocRedirectNode node);
    T VisitHeredocStart<T>(cHeredocStartNode node);
    T VisitHerestringRedirect<T>(cHerestringRedirectNode node);
    T VisitRegex<T>(cRegexNode node);
    T VisitSpecialVariableName<T>(cSpecialVariableNameNode node);
    T VisitStringContent<T>(cStringContentNode node);
    T VisitSubscript<T>(cSubscriptNode node);
    T VisitTestOperator<T>(cTestOperatorNode node);
    T VisitVariableName<T>(cVariableNameNode node);

    // root
    T VisitProgram<T>(cProgramNode node);

    // core
    T VisitConcreteBase<T>(cConcreteBaseAstNode node);
}
