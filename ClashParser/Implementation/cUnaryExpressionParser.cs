using Clash.Ast.Base;
using Clash.Ast.Nodes.Expr;
using Clash.Parser.Abstract;
using TreeSitter;

namespace Clash.Parser.Implementation;

public class cUnaryExpressionParser : ClashBaseParser {

    public cUnaryExpressionParser(string program, TreeSitter.Node node) : base(program, node)
    {
    }

    public override cIAstNode Parse(TreeSitter.Node tsNode) {
        this.CheckType(tsNode, "unary_expression");
        SyntaxInfo syntaxInfo = this.ExtractSyntaxInfo();

        TreeSitter.Node? tsOperator = tsNode.GetChildForField("operator");
        TreeSitter.Node tsOperand = this.FindOperand(tsNode, tsOperator);
        string @operator = this.GetProgramByOffsets(tsOperator);
        cIAstNode operand = this.Dispatcher(tsOperand).Parse(tsOperand);

        return new cUnaryExpressionNode(syntaxInfo, @operator, operand);
    }

    private TreeSitter.Node FindOperand(TreeSitter.Node tsNode, TreeSitter.Node tsOperator) {
        for (int i = 0; i < tsNode.NamedChildren.Count; i++) {
            TreeSitter.Node child = tsNode.NamedChildren[i];
            if (child.StartIndex != tsOperator.StartIndex
                    || child.EndIndex != tsOperator.EndIndex) {
                return child;
            }
        }

        throw new InvalidOperationException("unary_expression operand is missing");
    }
}
