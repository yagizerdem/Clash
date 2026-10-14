using Clash.Ast.Base;
using Clash.Ast.Nodes.Stmt;
using Clash.Parser.Abstract;
using TreeSitter;

namespace Clash.Parser.Implementation;

public class cIfStatementParser : ClashBaseParser {

    public cIfStatementParser(string program, TreeSitter.Node node) : base(program, node)
    {
    }

    public override IAstNode Parse(TreeSitter.Node tsNode) {
        this.CheckType(tsNode, "if_statement");
        SyntaxInfo syntaxInfo = this.ExtractSyntaxInfo();
        List<IAstNode> condition = [];
        List<IAstNode> thenBranch = [];
        List<IAstNode> elifClauses = [];
        IAstNode? elseClause = null;

        for (int i = 0; i < tsNode.NamedChildren.Count; i++) {
            TreeSitter.Node child = tsNode.NamedChildren[i];
            string fieldName = tsNode.GetFieldNameForNamedChild(i);
            IAstNode parsed = this.ParseChild(child);

            if ("condition".Equals(fieldName)) {
                condition.Add((StmtNode) parsed);
            } else if (child.Type.Equals("elif_clause")) {
                elifClauses.Add(parsed);
            } else if (child.Type.Equals("else_clause")) {
                elseClause = parsed;
            } else {
                thenBranch.Add((StmtNode) parsed);
            }
        }

        return new IfStatementNode(
                syntaxInfo,
                condition,
                thenBranch,
                elifClauses,
                elseClause
        );
    }
}
