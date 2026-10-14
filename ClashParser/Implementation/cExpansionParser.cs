using Clash.Ast.Base;
using Clash.Ast.Nodes.PrimaryExpr;
using Clash.Parser.Abstract;
using TreeSitter;

namespace Clash.Parser.Implementation;

public class cExpansionParser : ClashBaseParser {

    public cExpansionParser(string program, TreeSitter.Node node) : base(program, node)
    {
    }


    public override IAstNode Parse(TreeSitter.Node tsNode) {
        this.CheckType(tsNode, "expansion");
        SyntaxInfo syntaxInfo = this.ExtractSyntaxInfo();
        List<TreeSitter.Node> fieldNodes = this.GetChildrenByFieldName("operator");
        List<string> @operator = fieldNodes.Select(GetProgramByOffsets).ToList();
        List<IAstNode> parts = this.CollectNamedChildren(tsNode);
        return new ExpansionNode(syntaxInfo, @operator, parts);
    }
}
