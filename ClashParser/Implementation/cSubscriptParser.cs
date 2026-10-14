using Clash.Ast.Base;
using Clash.Ast.Nodes.Other;
using Clash.Parser.Abstract;
using TreeSitter;

namespace Clash.Parser.Implementation;

public class cSubscriptParser : ClashBaseParser {
    public cSubscriptParser(string program, TreeSitter.Node node) : base(program, node)
    {
    }

    public override cIAstNode Parse(TreeSitter.Node tsNode) {
        this.CheckType(tsNode, "subscript");
        TreeSitter.Node? tsName = tsNode.GetChildForField("name");
        TreeSitter.Node? tsIndex = tsNode.GetChildForField("index");
        List<cIAstNode> suffix = [];

        for (int i = 0; i < tsNode.NamedChildren.Count; i++) {
            if (tsNode.GetFieldNameForNamedChild(i) == null) {
                suffix.Add(this.ParseChild(tsNode.NamedChildren[i]));
            }
        }

        return new cSubscriptNode(
                this.ExtractSyntaxInfo(),
                this.ParseChild(tsName),
                this.ParseChild(tsIndex),
                suffix
        );
    }
}
