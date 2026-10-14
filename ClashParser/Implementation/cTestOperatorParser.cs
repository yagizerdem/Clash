using Clash.Ast.Base;
using Clash.Ast.Nodes.Other;
using Clash.Parser.Abstract;
using TreeSitter;

namespace Clash.Parser.Implementation;

public class cTestOperatorParser : ClashBaseParser {
    public cTestOperatorParser(string program, TreeSitter.Node node) : base(program, node)
    {
    }

    public override cIAstNode Parse(TreeSitter.Node tsNode) {
        this.CheckType(tsNode, "test_operator");
        SyntaxInfo syntaxInfo = this.ExtractSyntaxInfo();
        return new cTestOperatorNode(syntaxInfo, syntaxInfo.Raw);
    }
}
