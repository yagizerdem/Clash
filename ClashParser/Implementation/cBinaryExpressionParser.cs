using Clash.Ast.Base;
using Clash.Ast.Nodes.Expr;
using Clash.Parser.Abstract;
using TreeSitter;

namespace Clash.Parser.Implementation;

public class cBinaryExpressionParser : ClashBaseParser {

    public cBinaryExpressionParser(string program, TreeSitter.Node node) : base(program, node)
    {
    }


    public override IAstNode Parse(TreeSitter.Node tsNode) {
        this.CheckType(tsNode, "binary_expression");
        SyntaxInfo syntaxInfo = this.ExtractSyntaxInfo();
        TreeSitter.Node? tsLeftNode = tsNode.GetChildForField("left");
        TreeSitter.Node? tsOperatorNode = tsNode.GetChildForField("operator");
        string @operator = this.GetProgramByOffsets(tsOperatorNode);
        List<TreeSitter.Node> tsRightNodes = this.GetChildrenByFieldName(tsNode, "right");

        IAstNode? cLeftNode = this.IsMissing(tsLeftNode)
                ? null
                : this.ParseChild(tsLeftNode);
        List<IAstNode> cRightNodes = [];
        tsRightNodes.ForEach(tsn => {
            cRightNodes.Add(this.ParseChild(tsn));
        });

        return new BinaryExpressionNode(syntaxInfo, cLeftNode, @operator, cRightNodes);
    }
}
