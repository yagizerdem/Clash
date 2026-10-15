using Clash.Ast.Base;
using Clash.Ast.Nodes.Stmt;
using Clash.Parser.Abstract;
using TreeSitter;

namespace Clash.Parser.Implementation;

public class cRedirectedStatementParser : ClashBaseParser {

    public cRedirectedStatementParser(string program, TreeSitter.Node node) : base(program, node)
    {
    }

    public override cIAstNode Parse(TreeSitter.Node tsNode) {
        this.CheckType(tsNode, "redirected_statement");
        SyntaxInfo syntaxInfo = this.ExtractSyntaxInfo();
        TreeSitter.Node? tsBody = tsNode.GetChildForField("body");
        cStmtNode? body = this.IsMissing(tsBody)
                ? null
                : (cStmtNode) this.ParseChild(tsBody);
        List<cIAstNode> redirects = [];

        foreach (TreeSitter.Node child in this.GetChildrenByFieldName(tsNode, "redirect")) {
            redirects.Add(this.ParseChild(child));
        }

        return new cRedirectedStatementNode(syntaxInfo, body, redirects);
    }
}
