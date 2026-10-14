using Clash.Ast.Base;
using Clash.Ast.Nodes.Stmt;
using Clash.Parser.Abstract;
using TreeSitter;

namespace Clash.Parser.Implementation;

public class cCStyleForStatementParser : ClashBaseParser {

    public cCStyleForStatementParser(string program, TreeSitter.Node node) : base(program, node)
    {
    }

    public override cIAstNode Parse(TreeSitter.Node tsNode) {
        this.CheckType(tsNode, "c_style_for_statement");
        SyntaxInfo syntaxInfo = this.ExtractSyntaxInfo();
        List<cIAstNode> initializer = this.ParseFields(tsNode, "initializer");
        List<cIAstNode> condition = this.ParseFields(tsNode, "condition");
        List<cIAstNode> update = this.ParseFields(tsNode, "update");
        cIAstNode body = this.ParseChild(tsNode.GetChildForField("body"));
        return new cCStyleForStatementNode(syntaxInfo, initializer, condition, update, body);
    }

    private List<cIAstNode> ParseFields(TreeSitter.Node tsNode, string fieldName) {
        List<cIAstNode> nodes = [];
        foreach (TreeSitter.Node child in this.GetChildrenByFieldName(tsNode, fieldName)) {
            nodes.Add(this.ParseChild(child));
        }
        return nodes;
    }
}
