using Clash.Ast.Nodes.PrimaryExpr;
using Clash.Ast.Nodes.Other;
using Clash.Ast.Nodes.Expr;
using Clash.Ast.Base;
using Clash.Ast.Nodes;
using Clash.Ast.Nodes.Stmt;
using Clash.Ast.Visitor;
using Runtime.Evaluator;
using Runtime.Evaluator.Interface;

class EvaluationDispatcher : ConcreateBaseAstVisitor<Result>
{

    public override Result VisitProgram(cProgramNode node)
    {
        IEvaluator<Result> evaluator = new VisitProgram(this, node);
        return evaluator.Evaluate();
    }

    public override Result VisitForStatement(cForStatementNode node)
    {
        IEvaluator<Result> evaluator = new VisitForStatement(this, node);
        return evaluator.Evaluate();
    }

    public override Result VisitBinaryExpression(cBinaryExpressionNode node)
    {
        IEvaluator<Result> evaluator = new VisitBinaryExpression(this, node);
        return evaluator.Evaluate();
    }

    public override Result VisitConcatenation(cConcatenationNode node)
    {
        IEvaluator<Result> evaluator = new VisitConcatenation(this, node);
        return evaluator.Evaluate();
    }

    public override Result VisitParenthesizedExpression(cParenthesizedExpressionNode node)
    {
        IEvaluator<Result> evaluator = new VisitParenthesizedExpression(this, node);
        return evaluator.Evaluate();
    }

    public override Result VisitPostfixExpression(cPostfixExpressionNode node)
    {
        IEvaluator<Result> evaluator = new VisitPostfixExpression(this, node);
        return evaluator.Evaluate();
    }

    public override Result VisitTernaryExpression(cTernaryExpressionNode node)
    {
        IEvaluator<Result> evaluator = new VisitTernaryExpression(this, node);
        return evaluator.Evaluate();
    }

    public override Result VisitUnaryExpression(cUnaryExpressionNode node)
    {
        IEvaluator<Result> evaluator = new VisitUnaryExpression(this, node);
        return evaluator.Evaluate();
    }

    public override Result VisitWord(cWordNode node)
    {
        IEvaluator<Result> evaluator = new VisitWord(this, node);
        return evaluator.Evaluate();
    }

    public override Result VisitAnsiCString(cAnsiCStringNode node)
    {
        IEvaluator<Result> evaluator = new VisitAnsiCString(this, node);
        return evaluator.Evaluate();
    }

    public override Result VisitArithmeticExpansion(cArithmeticExpansionNode node)
    {
        IEvaluator<Result> evaluator = new VisitArithmeticExpansion(this, node);
        return evaluator.Evaluate();
    }

    public override Result VisitBraceExpression(cBraceExpressionNode node)
    {
        IEvaluator<Result> evaluator = new VisitBraceExpression(this, node);
        return evaluator.Evaluate();
    }

    public override Result VisitCommandSubstitution(cCommandSubstitutionNode node)
    {
        IEvaluator<Result> evaluator = new VisitCommandSubstitution(this, node);
        return evaluator.Evaluate();
    }

    public override Result VisitExpansion(cExpansionNode node)
    {
        IEvaluator<Result> evaluator = new VisitExpansion(this, node);
        return evaluator.Evaluate();
    }

    public override Result VisitNumber(cNumberNode node)
    {
        IEvaluator<Result> evaluator = new VisitNumber(this, node);
        return evaluator.Evaluate();
    }

    public override Result VisitProcessSubstitution(cProcessSubstitutionNode node)
    {
        IEvaluator<Result> evaluator = new VisitProcessSubstitution(this, node);
        return evaluator.Evaluate();
    }

    public override Result VisitRawString(cRawStringNode node)
    {
        IEvaluator<Result> evaluator = new VisitRawString(this, node);
        return evaluator.Evaluate();
    }

    public override Result VisitSimpleExpansion(cSimpleExpansionNode node)
    {
        IEvaluator<Result> evaluator = new VisitSimpleExpansion(this, node);
        return evaluator.Evaluate();
    }

    public override Result VisitString(cStringNode node)
    {
        IEvaluator<Result> evaluator = new VisitString(this, node);
        return evaluator.Evaluate();
    }

    public override Result VisitTranslatedString(cTranslatedStringNode node)
    {
        IEvaluator<Result> evaluator = new VisitTranslatedString(this, node);
        return evaluator.Evaluate();
    }

    public override Result VisitCStyleForStatement(cCStyleForStatementNode node)
    {
        IEvaluator<Result> evaluator = new VisitCStyleForStatement(this, node);
        return evaluator.Evaluate();
    }

    public override Result VisitCaseStatement(cCaseStatementNode node)
    {
        IEvaluator<Result> evaluator = new VisitCaseStatement(this, node);
        return evaluator.Evaluate();
    }

    public override Result VisitCommand(cCommandNode node)
    {
        IEvaluator<Result> evaluator = new VisitCommand(this, node);
        return evaluator.Evaluate();
    }

    public override Result VisitCompoundStatement(cCompoundStatementNode node)
    {
        IEvaluator<Result> evaluator = new VisitCompoundStatement(this, node);
        return evaluator.Evaluate();
    }

    public override Result VisitDeclarationCommand(cDeclarationCommandNode node)
    {
        IEvaluator<Result> evaluator = new VisitDeclarationCommand(this, node);
        return evaluator.Evaluate();
    }

    public override Result VisitFunctionDefinition(cFunctionDefinitionNode node)
    {
        IEvaluator<Result> evaluator = new VisitFunctionDefinition(this, node);
        return evaluator.Evaluate();
    }

    public override Result VisitIfStatement(cIfStatementNode node)
    {
        IEvaluator<Result> evaluator = new VisitIfStatement(this, node);
        return evaluator.Evaluate();
    }

    public override Result VisitList(cListNode node)
    {
        IEvaluator<Result> evaluator = new VisitList(this, node);
        return evaluator.Evaluate();
    }

    public override Result VisitNegatedCommand(cNegatedCommandNode node)
    {
        IEvaluator<Result> evaluator = new VisitNegatedCommand(this, node);
        return evaluator.Evaluate();
    }

    public override Result VisitPipeline(cPipelineNode node)
    {
        IEvaluator<Result> evaluator = new VisitPipeline(this, node);
        return evaluator.Evaluate();
    }

    public override Result VisitRedirectedStatement(cRedirectedStatementNode node)
    {
        IEvaluator<Result> evaluator = new VisitRedirectedStatement(this, node);
        return evaluator.Evaluate();
    }

    public override Result VisitSubshell(cSubshellNode node)
    {
        IEvaluator<Result> evaluator = new VisitSubshell(this, node);
        return evaluator.Evaluate();
    }

    public override Result VisitTestCommand(cTestCommandNode node)
    {
        IEvaluator<Result> evaluator = new VisitTestCommand(this, node);
        return evaluator.Evaluate();
    }

    public override Result VisitUnsetCommand(cUnsetCommandNode node)
    {
        IEvaluator<Result> evaluator = new VisitUnsetCommand(this, node);
        return evaluator.Evaluate();
    }

    public override Result VisitVariableAssignment(cVariableAssignmentNode node)
    {
        IEvaluator<Result> evaluator = new VisitVariableAssignment(this, node);
        return evaluator.Evaluate();
    }

    public override Result VisitVariableAssignments(cVariableAssignmentsNode node)
    {
        IEvaluator<Result> evaluator = new VisitVariableAssignments(this, node);
        return evaluator.Evaluate();
    }

    public override Result VisitWhileStatement(cWhileStatementNode node)
    {
        IEvaluator<Result> evaluator = new VisitWhileStatement(this, node);
        return evaluator.Evaluate();
    }

    public override Result VisitArray(cArrayNode node)
    {
        IEvaluator<Result> evaluator = new VisitArray(this, node);
        return evaluator.Evaluate();
    }

    public override Result VisitCaseItem(cCaseItemNode node)
    {
        IEvaluator<Result> evaluator = new VisitCaseItem(this, node);
        return evaluator.Evaluate();
    }

    public override Result VisitCommandName(cCommandNameNode node)
    {
        IEvaluator<Result> evaluator = new VisitCommandName(this, node);
        return evaluator.Evaluate();
    }

    public override Result VisitComment(cCommentNode node)
    {
        IEvaluator<Result> evaluator = new VisitComment(this, node);
        return evaluator.Evaluate();
    }

    public override Result VisitDoGroup(cDoGroupNode node)
    {
        IEvaluator<Result> evaluator = new VisitDoGroup(this, node);
        return evaluator.Evaluate();
    }

    public override Result VisitElifClause(cElifClauseNode node)
    {
        IEvaluator<Result> evaluator = new VisitElifClause(this, node);
        return evaluator.Evaluate();
    }

    public override Result VisitElseClause(cElseClauseNode node)
    {
        IEvaluator<Result> evaluator = new VisitElseClause(this, node);
        return evaluator.Evaluate();
    }

    public override Result VisitExtglobPattern(cExtglobPatternNode node)
    {
        IEvaluator<Result> evaluator = new VisitExtglobPattern(this, node);
        return evaluator.Evaluate();
    }

    public override Result VisitFileDescriptor(cFileDescriptorNode node)
    {
        IEvaluator<Result> evaluator = new VisitFileDescriptor(this, node);
        return evaluator.Evaluate();
    }

    public override Result VisitFileRedirect(cFileRedirectNode node)
    {
        IEvaluator<Result> evaluator = new VisitFileRedirect(this, node);
        return evaluator.Evaluate();
    }

    public override Result VisitHeredocBody(cHeredocBodyNode node)
    {
        IEvaluator<Result> evaluator = new VisitHeredocBody(this, node);
        return evaluator.Evaluate();
    }

    public override Result VisitHeredocContent(cHeredocContentNode node)
    {
        IEvaluator<Result> evaluator = new VisitHeredocContent(this, node);
        return evaluator.Evaluate();
    }

    public override Result VisitHeredocEnd(cHeredocEndNode node)
    {
        IEvaluator<Result> evaluator = new VisitHeredocEnd(this, node);
        return evaluator.Evaluate();
    }

    public override Result VisitHeredocRedirect(cHeredocRedirectNode node)
    {
        IEvaluator<Result> evaluator = new VisitHeredocRedirect(this, node);
        return evaluator.Evaluate();
    }

    public override Result VisitHeredocStart(cHeredocStartNode node)
    {
        IEvaluator<Result> evaluator = new VisitHeredocStart(this, node);
        return evaluator.Evaluate();
    }

    public override Result VisitHerestringRedirect(cHerestringRedirectNode node)
    {
        IEvaluator<Result> evaluator = new VisitHerestringRedirect(this, node);
        return evaluator.Evaluate();
    }

    public override Result VisitRegex(cRegexNode node)
    {
        IEvaluator<Result> evaluator = new VisitRegex(this, node);
        return evaluator.Evaluate();
    }

    public override Result VisitSpecialVariableName(cSpecialVariableNameNode node)
    {
        IEvaluator<Result> evaluator = new VisitSpecialVariableName(this, node);
        return evaluator.Evaluate();
    }

    public override Result VisitStringContent(cStringContentNode node)
    {
        IEvaluator<Result> evaluator = new VisitStringContent(this, node);
        return evaluator.Evaluate();
    }

    public override Result VisitSubscript(cSubscriptNode node)
    {
        IEvaluator<Result> evaluator = new VisitSubscript(this, node);
        return evaluator.Evaluate();
    }

    public override Result VisitTestOperator(cTestOperatorNode node)
    {
        IEvaluator<Result> evaluator = new VisitTestOperator(this, node);
        return evaluator.Evaluate();
    }

    public override Result VisitVariableName(cVariableNameNode node)
    {
        IEvaluator<Result> evaluator = new VisitVariableName(this, node);
        return evaluator.Evaluate();
    }

    public override Result VisitConcreteBase(cConcreteBaseAstNode node)
    {
        IEvaluator<Result> evaluator = new VisitConcreteBase(this, node);
        return evaluator.Evaluate();
    }
}
