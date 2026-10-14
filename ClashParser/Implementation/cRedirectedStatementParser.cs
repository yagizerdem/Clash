using Clash.Ast.Base;
using Clash.Ast.Nodes.Stmt;
using Clash.Parser.Abstract;
using TreeSitter;

namespace Clash.Parser.Implementation;

public class cRedirectedStatementParser : ClashBaseParser {

    public cRedirectedStatementParser(string program, TreeSitter.Node node) : base(program, node)
    {
    }

    public override IAstNode Parse(TreeSitter.Node tsNode) {
        this.CheckType(tsNode, "redirected_statement");
        SyntaxInfo syntaxInfo = this.ExtractSyntaxInfo();
        TreeSitter.Node? tsBody = tsNode.GetChildForField("body");
        StmtNode? body = this.IsMissing(tsBody)
                ? null
                : (StmtNode) this.ParseChild(tsBody);
        List<IAstNode> redirects = [];

        foreach (TreeSitter.Node child in this.GetChildrenByFieldName(tsNode, "redirect")) {
            redirects.Add(this.ParseChild(child));
        }

        return new RedirectedStatementNode(syntaxInfo, body, redirects);
    }
}
