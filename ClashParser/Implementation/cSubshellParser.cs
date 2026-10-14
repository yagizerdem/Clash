using Clash.Ast.Base;
using Clash.Ast.Nodes.Stmt;
using Clash.Parser.Abstract;
using TreeSitter;

namespace Clash.Parser.Implementation;

public class cSubshellParser : ClashBaseParser {

    public cSubshellParser(string program, TreeSitter.Node node) : base(program, node)
    {
    }

    public override cIAstNode Parse(TreeSitter.Node tsNode) {
        this.CheckType(tsNode, "subshell");
        SyntaxInfo syntaxInfo = this.ExtractSyntaxInfo();
        List<cIAstNode> statements = [];

        for (int i = 0; i < tsNode.NamedChildren.Count; i++) {
            statements.Add(this.ParseChild(tsNode.NamedChildren[i]));
        }

        return new cSubshellNode(syntaxInfo, statements);
    }
}
