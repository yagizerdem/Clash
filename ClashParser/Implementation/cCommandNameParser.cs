using Clash.Ast.Base;
using Clash.Ast.Nodes.Other;
using Clash.Parser.Abstract;
using TreeSitter;

namespace Clash.Parser.Implementation;

public class cCommandNameParser : ClashBaseParser {
    public cCommandNameParser(string program, TreeSitter.Node node) : base(program, node)
    {
    }

    public override IAstNode Parse(TreeSitter.Node tsNode) {
        this.CheckType(tsNode, "command_name");
        TreeSitter.Node tsValue = tsNode.NamedChildren[0];
        return new CommandNameNode(this.ExtractSyntaxInfo(), this.ParseChild(tsValue));
    }
}
