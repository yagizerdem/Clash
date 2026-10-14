using Clash.Ast.Base;
using Clash.Ast.Nodes.Other;
using Clash.Parser.Abstract;
using TreeSitter;

namespace Clash.Parser.Implementation;

public class cHeredocBodyParser : ClashBaseParser {
    public cHeredocBodyParser(string program, TreeSitter.Node node) : base(program, node)
    {
    }

    public override IAstNode Parse(TreeSitter.Node tsNode) {
        this.CheckType(tsNode, "heredoc_body");
        return new HeredocBodyNode(this.ExtractSyntaxInfo(), this.CollectNamedChildren(tsNode));
    }
}
