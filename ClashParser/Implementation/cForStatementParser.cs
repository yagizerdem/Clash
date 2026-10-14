using Clash.Ast.Base;
using Clash.Ast.Nodes.Stmt;
using Clash.Parser.Abstract;
using TreeSitter;

namespace Clash.Parser.Implementation;

public class cForStatementParser : ClashBaseParser {

    public cForStatementParser(string program, TreeSitter.Node node) : base(program, node)
    {
    }

    public override IAstNode Parse(TreeSitter.Node tsNode) {
        this.CheckType(tsNode, "for_statement");
        SyntaxInfo syntaxInfo = this.ExtractSyntaxInfo();
        IAstNode variable = this.ParseChild(tsNode.GetChildForField("variable"));
        IAstNode body = this.ParseChild(tsNode.GetChildForField("body"));
        List<IAstNode> values = [];

        foreach (TreeSitter.Node child in this.GetChildrenByFieldName(tsNode, "value")) {
            values.Add(this.ParseChild(child));
        }

        return new ForStatementNode(syntaxInfo, variable, values, body);
    }
}
