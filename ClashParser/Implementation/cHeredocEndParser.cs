using Clash.Ast.Base;
using Clash.Ast.Nodes.Other;
using Clash.Parser.Abstract;
using TreeSitter;

namespace Clash.Parser.Implementation;

public class cHeredocEndParser : ClashBaseParser {
    public cHeredocEndParser(string program, TreeSitter.Node node) : base(program, node)
    {
    }

    public override cIAstNode Parse(TreeSitter.Node tsNode) {
        this.CheckType(tsNode, "heredoc_end");
        return new cHeredocEndNode(this.ExtractSyntaxInfo());
    }
}
