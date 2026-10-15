using Clash.Ast.Base;
using Clash.Ast.Nodes.Other;
using Clash.Parser.Abstract;
using TreeSitter;

namespace Clash.Parser.Implementation;

public class cCommentParser : ClashBaseParser {
    public cCommentParser(string program, TreeSitter.Node node) : base(program, node)
    {
    }

    public override cIAstNode Parse(TreeSitter.Node tsNode) {
        this.CheckType(tsNode, "comment");
        SyntaxInfo syntaxInfo = this.ExtractSyntaxInfo();
        return new cCommentNode(syntaxInfo, syntaxInfo.Raw);
    }
}
