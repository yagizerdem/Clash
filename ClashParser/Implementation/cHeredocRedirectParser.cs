using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Nodes.Other;
using Clash.Parser.Abstract;
using TreeSitter;

namespace Clash.Parser.Implementation;

public class cHeredocRedirectParser : ClashBaseParser {
    public cHeredocRedirectParser(string program, TreeSitter.Node node) : base(program, node)
    {
    }

    public override cIAstNode Parse(TreeSitter.Node tsNode) {
        this.CheckType(tsNode, "heredoc_redirect");
        TreeSitter.Node? tsDescriptor = tsNode.GetChildForField("descriptor");
        TreeSitter.Node? tsOperator = tsNode.GetChildForField("operator");
        TreeSitter.Node? tsRight = tsNode.GetChildForField("right");

        cIAstNode? descriptor = this.IsMissing(tsDescriptor) ? null : this.ParseChild(tsDescriptor);
        string? @operator = this.IsMissing(tsOperator) ? null : this.GetProgramByOffsets(tsOperator);
        cStmtNode? right = this.IsMissing(tsRight) ? null : (cStmtNode) this.ParseChild(tsRight);
        List<cIAstNode> arguments = this.ParseFields(tsNode, "argument");
        List<cIAstNode> redirects = this.ParseFields(tsNode, "redirect");
        List<cIAstNode> parts = [];

        for (int i = 0; i < tsNode.NamedChildren.Count; i++) {
            if (tsNode.GetFieldNameForNamedChild(i) == null) {
                parts.Add(this.ParseChild(tsNode.NamedChildren[i]));
            }
        }

        return new cHeredocRedirectNode(
                this.ExtractSyntaxInfo(),
                descriptor,
                RedirectionKindExtensions.FromSymbol(this.FindRedirectOperator(tsNode)),
                arguments,
                @operator,
                redirects,
                right,
                parts
        );
    }

    private List<cIAstNode> ParseFields(TreeSitter.Node tsNode, string fieldName) {
        List<cIAstNode> nodes = [];
        foreach (TreeSitter.Node child in this.GetChildrenByFieldName(tsNode, fieldName)) {
            nodes.Add(this.ParseChild(child));
        }
        return nodes;
    }

    private string FindRedirectOperator(TreeSitter.Node tsNode) {
        for (int i = 0; i < tsNode.Children.Count; i++) {
            string raw = this.GetProgramByOffsets(tsNode.Children[i]);
            if (raw.Equals("<<") || raw.Equals("<<-")) {
                return raw;
            }
        }
        throw new InvalidOperationException("heredoc_redirect operator is missing");
    }
}
