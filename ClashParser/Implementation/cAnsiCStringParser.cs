using Clash.Ast.Base;
using Clash.Ast.Nodes.PrimaryExpr;
using Clash.Parser.Abstract;
using TreeSitter;

namespace Clash.Parser.Implementation;

public class cAnsiCStringParser : ClashBaseParser {

    public cAnsiCStringParser(string program, TreeSitter.Node node) : base(program, node)
    {
    }

    public override cIAstNode Parse(TreeSitter.Node tsNode) {
        this.CheckType(tsNode, "ansi_c_string");
        SyntaxInfo syntaxInfo = this.ExtractSyntaxInfo();
        return new cAnsiCStringNode(syntaxInfo);
    }
}
