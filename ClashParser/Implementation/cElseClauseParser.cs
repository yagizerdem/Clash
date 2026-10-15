using Clash.Ast.Base;
using Clash.Ast.Nodes.Other;
using Clash.Parser.Abstract;
using TreeSitter;

namespace Clash.Parser.Implementation;

public class cElseClauseParser : ClashBaseParser {
    public cElseClauseParser(string program, TreeSitter.Node node) : base(program, node)
    {
    }

    public override cIAstNode Parse(TreeSitter.Node tsNode) {
        this.CheckType(tsNode, "else_clause");
        List<cIAstNode> statements = [];
        for (int i = 0; i < tsNode.NamedChildren.Count; i++) {
            statements.Add((cStmtNode) this.ParseChild(tsNode.NamedChildren[i]));
        }
        return new cElseClauseNode(this.ExtractSyntaxInfo(), statements);
    }
}
