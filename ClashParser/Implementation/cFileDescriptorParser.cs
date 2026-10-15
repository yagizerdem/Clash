using Clash.Ast.Base;
using Clash.Ast.Nodes.Other;
using Clash.Parser.Abstract;
using TreeSitter;

namespace Clash.Parser.Implementation;

public class cFileDescriptorParser : ClashBaseParser {
    public cFileDescriptorParser(string program, TreeSitter.Node node) : base(program, node)
    {
    }

    public override cIAstNode Parse(TreeSitter.Node tsNode) {
        this.CheckType(tsNode, "file_descriptor");
        return new cFileDescriptorNode(this.ExtractSyntaxInfo());
    }
}
