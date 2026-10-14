using Clash.Ast.Base;
using Clash.Ast.Nodes.Stmt;
using Clash.Parser.Abstract;
using TreeSitter;

namespace Clash.Parser.Implementation;

public class cCaseStatementParser : ClashBaseParser {

    public cCaseStatementParser(string program, TreeSitter.Node node) : base(program, node)
    {
    }

    public override cIAstNode Parse(TreeSitter.Node tsNode) {
        this.CheckType(tsNode, "case_statement");
        SyntaxInfo syntaxInfo = this.ExtractSyntaxInfo();
        TreeSitter.Node? tsValue = tsNode.GetChildForField("value");
        cIAstNode value = this.ParseChild(tsValue!);
        List<cIAstNode> items = [];

        for (int i = 0; i < tsNode.NamedChildren.Count; i++) {
            TreeSitter.Node child = tsNode.NamedChildren[i];
            if (child.Type.Equals("case_item")) {
                items.Add(this.ParseChild(child));
            }
        }

        return new cCaseStatementNode(syntaxInfo, value, items);
    }
}
