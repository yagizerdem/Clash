using Clash.Ast.Base;
using Clash.Ast.Nodes.Stmt;
using Clash.Parser.Abstract;
using TreeSitter;

namespace Clash.Parser.Implementation;

public class cVariableAssignmentsParser : ClashBaseParser {

    public cVariableAssignmentsParser(string program, TreeSitter.Node node) : base(program, node)
    {
    }

    public override IAstNode Parse(TreeSitter.Node tsNode) {
        this.CheckType(tsNode, "variable_assignments");
        SyntaxInfo syntaxInfo = this.ExtractSyntaxInfo();
        List<VariableAssignmentNode> assignments = [];

        for (int i = 0; i < tsNode.NamedChildren.Count; i++) {
            assignments.Add((VariableAssignmentNode) this.ParseChild(tsNode.NamedChildren[i]));
        }

        return new VariableAssignmentsNode(syntaxInfo, assignments);
    }
}
