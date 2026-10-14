using Clash.Ast.Base;
using Clash.Ast.Nodes.Other;
using Clash.Parser.Abstract;
using TreeSitter;

namespace Clash.Parser.Implementation;

public class cHeredocStartParser : ClashBaseParser {
    public cHeredocStartParser(string program, TreeSitter.Node node) : base(program, node)
    {
    }

    public override IAstNode Parse(TreeSitter.Node tsNode) {
        this.CheckType(tsNode, "heredoc_start");
        return new HeredocStartNode(this.ExtractSyntaxInfo());
    }
}
