using Clash.Ast.Base;
using Clash.Ast.Nodes.Stmt;
using Clash.Parser.Abstract;
using TreeSitter;

namespace Clash.Parser.Implementation;

public class cTestCommandParser : ClashBaseParser {

    public cTestCommandParser(string program, TreeSitter.Node node) : base(program, node)
    {
    }

    public override IAstNode Parse(TreeSitter.Node tsNode) {
        this.CheckType(tsNode, "test_command");
        SyntaxInfo syntaxInfo = this.ExtractSyntaxInfo();
        IAstNode? expression = tsNode.NamedChildren.Count == 0
                ? null
                : this.ParseChild(tsNode.NamedChildren[0]);
        return new TestCommandNode(syntaxInfo, expression);
    }
}
