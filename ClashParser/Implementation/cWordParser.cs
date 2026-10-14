using Clash.Ast.Base;
using Clash.Ast.Nodes.Expr;
using Clash.Parser.Abstract;
using TreeSitter;

namespace Clash.Parser.Implementation;

public class cWordParser : ClashBaseParser {

    public cWordParser(string program, TreeSitter.Node node) : base(program, node)
    {
    }

    public override IAstNode Parse(TreeSitter.Node tsNode) {
        this.CheckType(tsNode, "word");
        SyntaxInfo syntaxInfo = this.ExtractSyntaxInfo();
        return new WordNode(syntaxInfo);
    }

}
