using Clash.Ast.Base;
using Clash.Ast.Nodes.PrimaryExpr;
using Clash.Parser.Abstract;
using TreeSitter;

namespace Clash.Parser.Implementation;

public class cTranslatedStringParser : ClashBaseParser {

    public cTranslatedStringParser(string program, TreeSitter.Node node) : base(program, node)
    {
    }

    public override cIAstNode Parse(TreeSitter.Node tsNode) {
        this.CheckType(tsNode, "translated_string");
        SyntaxInfo syntaxInfo = this.ExtractSyntaxInfo();
        TreeSitter.Node stringTsNode = tsNode.NamedChildren[0];
        cIAstNode stringAst = this.Dispatcher(stringTsNode).Parse(stringTsNode);
        return new cTranslatedStringNode(syntaxInfo, stringAst);
    }
}
