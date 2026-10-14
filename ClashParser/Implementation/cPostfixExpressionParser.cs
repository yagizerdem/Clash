using Clash.Ast.Base;
using Clash.Ast.Nodes.Expr;
using Clash.Parser.Abstract;
using TreeSitter;

namespace Clash.Parser.Implementation;

public class cPostfixExpressionParser : ClashBaseParser {

    public cPostfixExpressionParser(string program, TreeSitter.Node node) : base(program, node)
    {
    }

    public override IAstNode Parse(TreeSitter.Node tsNode) {
        this.CheckType(tsNode, "postfix_expression");
        SyntaxInfo syntaxInfo = this.ExtractSyntaxInfo();

        TreeSitter.Node tsOperand = tsNode.NamedChildren[0];
        TreeSitter.Node? tsOperator = tsNode.GetChildForField("operator");
        IAstNode operand = this.Dispatcher(tsOperand).Parse(tsOperand);
        string @operator = this.GetProgramByOffsets(tsOperator);

        return new PostfixExpressionNode(syntaxInfo, operand, @operator);
    }
}
