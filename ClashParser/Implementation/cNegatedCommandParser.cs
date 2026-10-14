using Clash.Ast.Base;
using Clash.Ast.Nodes.Stmt;
using Clash.Parser.Abstract;
using TreeSitter;

namespace Clash.Parser.Implementation;

public class cNegatedCommandParser : ClashBaseParser {

    public cNegatedCommandParser(string program, TreeSitter.Node node) : base(program, node)
    {
    }

    public override cIAstNode Parse(TreeSitter.Node tsNode) {
        this.CheckType(tsNode, "negated_command");
        SyntaxInfo syntaxInfo = this.ExtractSyntaxInfo();
        TreeSitter.Node tsCommand = tsNode.NamedChildren[0];
        cStmtNode command = (cStmtNode) this.ParseChild(tsCommand);
        return new cNegatedCommandNode(syntaxInfo, command);
    }
}
