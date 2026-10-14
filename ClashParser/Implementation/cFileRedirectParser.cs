using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Nodes.Other;
using Clash.Parser.Abstract;
using TreeSitter;

namespace Clash.Parser.Implementation;

public class cFileRedirectParser : ClashBaseParser {
    private static readonly HashSet<string> Operators = ["<", ">", ">>", "&>", "&>>", "<&", ">&", ">|", "<&-", ">&-"];

    public cFileRedirectParser(string program, TreeSitter.Node node) : base(program, node)
    {
    }

    public override IAstNode Parse(TreeSitter.Node tsNode) {
        this.CheckType(tsNode, "file_redirect");
        TreeSitter.Node? tsDescriptor = tsNode.GetChildForField("descriptor");
        IAstNode? descriptor = this.IsMissing(tsDescriptor) ? null : this.ParseChild(tsDescriptor);
        List<IAstNode> destinations = [];
        foreach (TreeSitter.Node child in this.GetChildrenByFieldName(tsNode, "destination")) {
            destinations.Add(this.ParseChild(child));
        }

        return new FileRedirectNode(
                this.ExtractSyntaxInfo(),
                descriptor,
                RedirectionKindExtensions.FromSymbol(this.FindOperator(tsNode)),
                destinations
        );
    }

    private string FindOperator(TreeSitter.Node tsNode) {
        for (int i = 0; i < tsNode.Children.Count; i++) {
            string raw = this.GetProgramByOffsets(tsNode.Children[i]);
            if (Operators.Contains(raw)) {
                return raw;
            }
        }
        throw new InvalidOperationException("file_redirect operator is missing");
    }
}
