using Clash.Ast.Base;
using Clash.Ast.Nodes.Other;
using Clash.Parser.Abstract;
using TreeSitter;

namespace Clash.Parser.Implementation;

public class cHerestringRedirectParser : ClashBaseParser {
    public cHerestringRedirectParser(string program, TreeSitter.Node node) : base(program, node)
    {
    }

    public override cIAstNode Parse(TreeSitter.Node tsNode) {
        this.CheckType(tsNode, "herestring_redirect");
        TreeSitter.Node? tsDescriptor = tsNode.GetChildForField("descriptor");
        cIAstNode? descriptor = this.IsMissing(tsDescriptor) ? null : this.ParseChild(tsDescriptor);
        TreeSitter.Node tsValue = this.FindValue(tsNode, tsDescriptor);
        return new cHerestringRedirectNode(
                this.ExtractSyntaxInfo(),
                descriptor,
                this.ParseChild(tsValue)
        );
    }

    private TreeSitter.Node FindValue(TreeSitter.Node tsNode, TreeSitter.Node tsDescriptor) {
        for (int i = 0; i < tsNode.NamedChildren.Count; i++) {
            TreeSitter.Node child = tsNode.NamedChildren[i];
            if (this.IsMissing(tsDescriptor)
                    || child.StartIndex != tsDescriptor.StartIndex
                    || child.EndIndex != tsDescriptor.EndIndex) {
                return child;
            }
        }
        throw new InvalidOperationException("herestring_redirect value is missing");
    }
}
