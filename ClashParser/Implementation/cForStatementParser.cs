using Clash.Ast.Base;
using Clash.Ast.Nodes.Stmt;
using Clash.Parser.Abstract;
using TreeSitter;

namespace Clash.Parser.Implementation;

public class cForStatementParser : ClashBaseParser {

    public cForStatementParser(string program, TreeSitter.Node node) : base(program, node)
    {
    }

    public override cIAstNode Parse(TreeSitter.Node tsNode) {
        this.CheckType(tsNode, "for_statement");
        SyntaxInfo syntaxInfo = this.ExtractSyntaxInfo();
        cIAstNode variable = this.ParseChild(tsNode.GetChildForField("variable"));
        cIAstNode body = this.ParseChild(tsNode.GetChildForField("body"));
        List<cIAstNode> values = [];

        foreach (TreeSitter.Node child in this.GetChildrenByFieldName(tsNode, "value")) {
            values.Add(this.ParseChild(child));
        }

        return new cForStatementNode(syntaxInfo, variable, values, body);
    }
}
