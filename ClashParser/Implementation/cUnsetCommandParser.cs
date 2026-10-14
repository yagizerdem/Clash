using Clash.Ast.Base;
using Clash.Ast.Nodes.Stmt;
using Clash.Parser.Abstract;
using TreeSitter;

namespace Clash.Parser.Implementation;

public class cUnsetCommandParser : ClashBaseParser {

    public cUnsetCommandParser(string program, TreeSitter.Node node) : base(program, node)
    {
    }

    public override IAstNode Parse(TreeSitter.Node tsNode) {
        this.CheckType(tsNode, "unset_command");
        SyntaxInfo syntaxInfo = this.ExtractSyntaxInfo();
        List<IAstNode> targets = this.CollectNamedChildren(tsNode);
        return new UnsetCommandNode(syntaxInfo, targets);
    }
}
