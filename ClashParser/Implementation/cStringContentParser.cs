using Clash.Ast.Base;
using Clash.Ast.Nodes.Other;
using Clash.Parser.Abstract;
using TreeSitter;

namespace Clash.Parser.Implementation;

public class cStringContentParser : ClashBaseParser {
    public cStringContentParser(string program, TreeSitter.Node node) : base(program, node)
    {
    }

    public override IAstNode Parse(TreeSitter.Node tsNode) {
        this.CheckType(tsNode, "string_content");
        SyntaxInfo syntaxInfo = this.ExtractSyntaxInfo();
        return new StringContentNode(syntaxInfo, syntaxInfo.Raw);
    }
}
