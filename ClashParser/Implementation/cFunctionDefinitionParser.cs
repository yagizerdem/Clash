using Clash.Ast.Base;
using Clash.Ast.Nodes.Stmt;
using Clash.Parser.Abstract;
using TreeSitter;

namespace Clash.Parser.Implementation;

public class cFunctionDefinitionParser : ClashBaseParser {

    public cFunctionDefinitionParser(string program, TreeSitter.Node node) : base(program, node)
    {
    }

    public override IAstNode Parse(TreeSitter.Node tsNode) {
        this.CheckType(tsNode, "function_definition");
        SyntaxInfo syntaxInfo = this.ExtractSyntaxInfo();
        IAstNode name = this.ParseChild(tsNode.GetChildForField("name"));
        IAstNode body = this.ParseChild(tsNode.GetChildForField("body"));
        List<IAstNode> redirects = [];

        foreach (TreeSitter.Node child in this.GetChildrenByFieldName(tsNode, "redirect")) {
            redirects.Add(this.ParseChild(child));
        }

        return new FunctionDefinitionNode(syntaxInfo, name, body, redirects);
    }
}
