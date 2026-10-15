using Clash.Ast.Base;
using Clash.Ast.Nodes.Stmt;
using Clash.Parser.Abstract;
using TreeSitter;

namespace Clash.Parser.Implementation;

public class cCompoundStatementParser : ClashBaseParser {

    public cCompoundStatementParser(string program, TreeSitter.Node node) : base(program, node)
    {
    }

    public override cIAstNode Parse(TreeSitter.Node tsNode) {
        this.CheckType(tsNode, "compound_statement");
        SyntaxInfo syntaxInfo = this.ExtractSyntaxInfo();
        List<cIAstNode> elements = this.CollectNamedChildren(tsNode);
        return new cCompoundStatementNode(syntaxInfo, elements);
    }
}
