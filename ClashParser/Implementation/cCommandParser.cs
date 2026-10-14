using Clash.Ast.Base;
using Clash.Ast.Nodes.Stmt;
using Clash.Parser.Abstract;
using TreeSitter;

namespace Clash.Parser.Implementation;

public class cCommandParser : ClashBaseParser {

    public cCommandParser(string program, TreeSitter.Node node) : base(program, node)
    {
    }

    public override cIAstNode Parse(TreeSitter.Node tsNode) {
        this.CheckType(tsNode, "command");
        SyntaxInfo syntaxInfo = this.ExtractSyntaxInfo();
        if(this.IsMissing(tsNode.GetChildForField("name")))
        {
            throw new ArgumentException("Cannot parse a command without a name");
        }
        cIAstNode name = this.ParseChild(tsNode.GetChildForField("name")!);
        List<cIAstNode> arguments = this.ParseFields(tsNode, "argument");
        List<cIAstNode> redirects = this.ParseFields(tsNode, "redirect");
        List<cIAstNode> prefixes = [];

        for (int i = 0; i < tsNode.NamedChildren.Count; i++) {
            TreeSitter.Node child = tsNode.NamedChildren[i];
            if (child.Type.Equals("variable_assignment")
                    || child.Type.Equals("subshell")) {
                prefixes.Add(this.ParseChild(child));
            }
        }

        return new cCommandNode(syntaxInfo, name, arguments, redirects, prefixes);
    }

    private List<cIAstNode> ParseFields(TreeSitter.Node tsNode, string fieldName) {
        List<cIAstNode> nodes = [];
        foreach (TreeSitter.Node child in this.GetChildrenByFieldName(tsNode, fieldName)) {
            nodes.Add(this.ParseChild(child));
        }
        return nodes;
    }
}
