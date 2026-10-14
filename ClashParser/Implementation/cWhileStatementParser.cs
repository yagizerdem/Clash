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

    public override IAstNode Parse(TreeSitter.Node tsNode) {
        this.CheckType(tsNode, "while_statement");
        SyntaxInfo syntaxInfo = this.ExtractSyntaxInfo();
        LoopKind loopKind = syntaxInfo.Raw.TrimStart().StartsWith("until")
                ? LoopKind.Until
                : LoopKind.While;
        List<IAstNode> condition = [];

        foreach (TreeSitter.Node child in this.GetChildrenByFieldName(tsNode, "condition")) {
            if (child.IsNamed) {
                condition.Add((StmtNode) this.ParseChild(child));
            }
        }

        IAstNode body = this.ParseChild(tsNode.GetChildForField("body"));
        return new WhileStatementNode(syntaxInfo, loopKind, condition, body);
    }
}
