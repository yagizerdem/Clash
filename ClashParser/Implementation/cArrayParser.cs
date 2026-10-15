using Clash.Ast.Base;
using Clash.Ast.Nodes.Other;
using Clash.Parser.Abstract;
using TreeSitter;

namespace Clash.Parser.Implementation;

public class cArrayParser : ClashBaseParser {
    public cArrayParser(string program, TreeSitter.Node node) : base(program, node)
    {
    }

    public override cIAstNode Parse(TreeSitter.Node tsNode) {
        this.CheckType(tsNode, "array");
        return new cArrayNode(this.ExtractSyntaxInfo(), this.CollectNamedChildren(tsNode));
    }
}
