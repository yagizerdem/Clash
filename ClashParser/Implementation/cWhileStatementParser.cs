using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Nodes.Stmt;
using Clash.Parser.Abstract;
using TreeSitter;

namespace Clash.Parser.Implementation;

public class cWhileStatementParser : ClashBaseParser {

    public cWhileStatementParser(string program, TreeSitter.Node node) : base(program, node)
    {
    }

    public override cIAstNode Parse(TreeSitter.Node tsNode) {
        this.CheckType(tsNode, "while_statement");
        SyntaxInfo syntaxInfo = this.ExtractSyntaxInfo();
        LoopKind loopKind = syntaxInfo.Raw.TrimStart().StartsWith("until")
                ? LoopKind.Until
                : LoopKind.While;
        List<cIAstNode> condition = [];

        foreach (TreeSitter.Node child in this.GetChildrenByFieldName(tsNode, "condition")) {
            if (child.IsNamed) {
                condition.Add((cStmtNode) this.ParseChild(child));
            }
        }

        cIAstNode body = this.ParseChild(tsNode.GetChildForField("body"));
        return new cWhileStatementNode(syntaxInfo, loopKind, condition, body);
    }
}
