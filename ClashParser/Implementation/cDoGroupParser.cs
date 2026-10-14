using Clash.Ast.Base;
using Clash.Ast.Nodes.Other;
using Clash.Parser.Abstract;
using TreeSitter;

namespace Clash.Parser.Implementation;

public class cDoGroupParser : ClashBaseParser {
    public cDoGroupParser(string program, TreeSitter.Node node) : base(program, node)
    {
    }

    public override IAstNode Parse(TreeSitter.Node tsNode) {
        this.CheckType(tsNode, "do_group");
        List<IAstNode> statements = [];
        for (int i = 0; i < tsNode.NamedChildren.Count; i++) {
            statements.Add(this.ParseChild(tsNode.NamedChildren[i]));
        }
        return new DoGroupNode(this.ExtractSyntaxInfo(), statements);
    }
}
