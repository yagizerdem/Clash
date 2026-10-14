using Clash.Ast.Base;
using Clash.Ast.Nodes.Other;
using Clash.Parser.Abstract;
using TreeSitter;

namespace Clash.Parser.Implementation;

public class cElseClauseParser : ClashBaseParser {
    public cElseClauseParser(string program, TreeSitter.Node node) : base(program, node)
    {
    }

    public override IAstNode Parse(TreeSitter.Node tsNode) {
        this.CheckType(tsNode, "else_clause");
        List<IAstNode> statements = [];
        for (int i = 0; i < tsNode.NamedChildren.Count; i++) {
            statements.Add((StmtNode) this.ParseChild(tsNode.NamedChildren[i]));
        }
        return new ElseClauseNode(this.ExtractSyntaxInfo(), statements);
    }
}
