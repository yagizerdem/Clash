using Clash.Ast.Base;
using Clash.Ast.Nodes;
using Clash.Parser.Abstract;
using TreeSitter;

namespace Clash.Parser.Implementation;

public class cProgramParse : ClashBaseParser {

    public cProgramParse(string program, TreeSitter.Node node) : base(program, node)
    {
    }

    public override cIAstNode Parse(TreeSitter.Node tsNode) {
        this.CheckType(tsNode, "program");
        SyntaxInfo syntaxInfo = this.ExtractSyntaxInfo();
        List<cIAstNode> stmts = this.CollectNamedChildren();
        return new cProgramNode(syntaxInfo, stmts);
    }
}
