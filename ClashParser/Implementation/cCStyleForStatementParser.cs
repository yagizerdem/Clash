using Clash.Ast.Base;
using Clash.Ast.Nodes.Stmt;
using Clash.Parser.Abstract;
using TreeSitter;

namespace Clash.Parser.Implementation;

public class cCStyleForStatementParser : ClashBaseParser {

    public cCStyleForStatementParser(string program, TreeSitter.Node node) : base(program, node)
    {
    }

    public override IAstNode Parse(TreeSitter.Node tsNode) {
        this.CheckType(tsNode, "c_style_for_statement");
        SyntaxInfo syntaxInfo = this.ExtractSyntaxInfo();
        List<IAstNode> initializer = this.ParseFields(tsNode, "initializer");
        List<IAstNode> condition = this.ParseFields(tsNode, "condition");
        List<IAstNode> update = this.ParseFields(tsNode, "update");
        IAstNode body = this.ParseChild(tsNode.GetChildForField("body"));
        return new CStyleForStatementNode(syntaxInfo, initializer, condition, update, body);
    }

    private List<IAstNode> ParseFields(TreeSitter.Node tsNode, string fieldName) {
        List<IAstNode> nodes = [];
        foreach (TreeSitter.Node child in this.GetChildrenByFieldName(tsNode, fieldName)) {
            nodes.Add(this.ParseChild(child));
        }
        return nodes;
    }
}
