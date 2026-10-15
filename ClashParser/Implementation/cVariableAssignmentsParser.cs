using Clash.Ast.Base;
using Clash.Ast.Nodes.Stmt;
using Clash.Parser.Abstract;
using TreeSitter;

namespace Clash.Parser.Implementation;

public class cVariableAssignmentsParser : ClashBaseParser {

    public cVariableAssignmentsParser(string program, TreeSitter.Node node) : base(program, node)
    {
    }

    public override cIAstNode Parse(TreeSitter.Node tsNode) {
        this.CheckType(tsNode, "variable_assignments");
        SyntaxInfo syntaxInfo = this.ExtractSyntaxInfo();
        List<cVariableAssignmentNode> assignments = [];

        for (int i = 0; i < tsNode.NamedChildren.Count; i++) {
            assignments.Add((cVariableAssignmentNode) this.ParseChild(tsNode.NamedChildren[i]));
        }

        return new cVariableAssignmentsNode(syntaxInfo, assignments);
    }
}
