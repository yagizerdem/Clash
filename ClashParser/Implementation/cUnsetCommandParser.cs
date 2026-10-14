using Clash.Ast.Base;
using Clash.Ast.Nodes.Stmt;
using Clash.Parser.Abstract;
using TreeSitter;

namespace Clash.Parser.Implementation;

public class cUnsetCommandParser : ClashBaseParser {

    public cUnsetCommandParser(string program, TreeSitter.Node node) : base(program, node)
    {
    }

    public override cIAstNode Parse(TreeSitter.Node tsNode) {
        this.CheckType(tsNode, "unset_command");
        SyntaxInfo syntaxInfo = this.ExtractSyntaxInfo();
        List<cIAstNode> targets = this.CollectNamedChildren(tsNode);
        return new cUnsetCommandNode(syntaxInfo, targets);
    }
}
