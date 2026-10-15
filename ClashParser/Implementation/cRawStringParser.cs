using Clash.Ast.Base;
using Clash.Ast.Nodes.PrimaryExpr;
using Clash.Parser.Abstract;
using TreeSitter;

namespace Clash.Parser.Implementation;

public class cRawStringParser : ClashBaseParser {

    public cRawStringParser(string program, TreeSitter.Node node) : base(program, node)
    {
    }

    public override cIAstNode Parse(TreeSitter.Node tsNode) {
        this.CheckType(tsNode, "raw_string");
        SyntaxInfo syntaxInfo = this.ExtractSyntaxInfo();
        return new cRawStringNode(syntaxInfo);
    }
}
