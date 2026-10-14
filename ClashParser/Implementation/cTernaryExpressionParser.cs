using Clash.Ast.Base;
using Clash.Ast.Nodes.Expr;
using Clash.Parser.Abstract;
using TreeSitter;

namespace Clash.Parser.Implementation;

public class cTernaryExpressionParser : ClashBaseParser {

    public cTernaryExpressionParser(string program, TreeSitter.Node node) : base(program, node)
    {
    }

    public override IAstNode Parse(TreeSitter.Node tsNode) {
        this.CheckType(tsNode, "ternary_expression");
        SyntaxInfo syntaxInfo = this.ExtractSyntaxInfo();

        IAstNode condition = this.ParseField(tsNode, "condition");
        IAstNode consequence = this.ParseField(tsNode, "consequence");
        IAstNode alternative = this.ParseField(tsNode, "alternative");

        return new TernaryExpressionNode(
                syntaxInfo,
                condition,
                consequence,
                alternative
        );
    }

    private IAstNode ParseField(TreeSitter.Node tsNode, string fieldName) {
        TreeSitter.Node? tsField = tsNode.GetChildForField(fieldName);
        return this.Dispatcher(tsField).Parse(tsField);
    }
}
