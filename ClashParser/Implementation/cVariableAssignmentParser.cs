using Clash.Ast.Base;
using Clash.Ast.Nodes.Stmt;
using Clash.Parser.Abstract;
using TreeSitter;

namespace Clash.Parser.Implementation;

public class cVariableAssignmentParser : ClashBaseParser {

    public cVariableAssignmentParser(string program, TreeSitter.Node node) : base(program, node)
    {
    }

    public override IAstNode Parse(TreeSitter.Node tsNode) {
        this.CheckType(tsNode, "variable_assignment");
        SyntaxInfo syntaxInfo = this.ExtractSyntaxInfo();

        TreeSitter.Node? tsNameNode = tsNode.GetChildForField("name");
        TreeSitter.Node? tsValueNode = tsNode.GetChildForField("value");

        IAstNode nameNode = this.Dispatcher(tsNameNode).Parse(tsNameNode);
        IAstNode valueNode = this.Dispatcher(tsValueNode).Parse(tsValueNode);

        VariableAssignmentNode node = new VariableAssignmentNode(syntaxInfo, nameNode, valueNode);
        return node;
    }
}
