using Clash.Ast.Base;
using Clash.Ast.Nodes.Other;
using Clash.Parser.Abstract;
using TreeSitter;

namespace Clash.Parser.Implementation;

public class cDoGroupParser : ClashBaseParser {
    public cDoGroupParser(string program, TreeSitter.Node node) : base(program, node)
    {
    }

    public override cIAstNode Parse(TreeSitter.Node tsNode) {
        this.CheckType(tsNode, "do_group");
        List<cIAstNode> statements = [];
        for (int i = 0; i < tsNode.NamedChildren.Count; i++) {
            statements.Add(this.ParseChild(tsNode.NamedChildren[i]));
        }
        return new cDoGroupNode(this.ExtractSyntaxInfo(), statements);
    }
}
