using Clash.Ast.Base;
using Clash.Ast.Nodes.Other;
using Clash.Parser.Abstract;
using TreeSitter;

namespace Clash.Parser.Implementation;

public class cCaseItemParser : ClashBaseParser {
    public cCaseItemParser(string program, TreeSitter.Node node) : base(program, node)
    {
    }

    public override cIAstNode Parse(TreeSitter.Node tsNode) {
        this.CheckType(tsNode, "case_item");
        List<cIAstNode> values = [];
        List<cIAstNode> statements = [];

        foreach (TreeSitter.Node child in this.GetChildrenByFieldName(tsNode, "value")) {
            values.Add(this.ParseChild(child));
        }

        for (int i = 0; i < tsNode.NamedChildren.Count; i++) {
            TreeSitter.Node child = tsNode.NamedChildren[i];
            if (tsNode.GetFieldNameForNamedChild(i) == null) {
                statements.Add((cStmtNode) this.ParseChild(child));
            }
        }

        TreeSitter.Node? tsTerminator = tsNode.GetChildForField("termination");
        if (this.IsMissing(tsTerminator)) {
            tsTerminator = tsNode.GetChildForField("fallthrough");
        }
        string? terminator = this.IsMissing(tsTerminator)
                ? null
                : this.GetProgramByOffsets(tsTerminator!);

        return new cCaseItemNode(this.ExtractSyntaxInfo(), values, statements, terminator);
    }
}
