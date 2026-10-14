using Clash.Ast.Base;
using Clash.Ast.Nodes.Expr;
using Clash.Parser.Abstract;
using TreeSitter;

namespace Clash.Parser.Implementation;

public class cBinaryExpressionParser : ClashBaseParser {

    public cBinaryExpressionParser(string program, TreeSitter.Node node) : base(program, node)
    {
    }


    public override cIAstNode Parse(TreeSitter.Node tsNode) {
        this.CheckType(tsNode, "binary_expression");
        SyntaxInfo syntaxInfo = this.ExtractSyntaxInfo();
        TreeSitter.Node? tsLeftNode = tsNode.GetChildForField("left");
        TreeSitter.Node? tsOperatorNode = tsNode.GetChildForField("operator");
        string @operator = this.GetProgramByOffsets(tsOperatorNode);
        List<TreeSitter.Node> tsRightNodes = this.GetChildrenByFieldName(tsNode, "right");

        cIAstNode? cLeftNode = this.IsMissing(tsLeftNode)
                ? null
                : this.ParseChild(tsLeftNode);
        List<cIAstNode> cRightNodes = [];
        tsRightNodes.ForEach(tsn => {
            cRightNodes.Add(this.ParseChild(tsn));
        });

        return new cBinaryExpressionNode(syntaxInfo, cLeftNode, @operator, cRightNodes);
    }
}
