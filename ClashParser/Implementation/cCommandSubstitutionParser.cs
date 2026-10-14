using Clash.Ast.Base;
using Clash.Ast.Nodes.PrimaryExpr;
using Clash.Parser.Abstract;
using TreeSitter;

namespace Clash.Parser.Implementation;

public class cCommandSubstitutionParser : ClashBaseParser {

    public cCommandSubstitutionParser(string program, TreeSitter.Node node) : base(program, node)
    {
    }


    public override cIAstNode Parse(TreeSitter.Node tsNode) {
        this.CheckType(tsNode, "command_substitution");
        SyntaxInfo syntaxInfo = this.ExtractSyntaxInfo();

        TreeSitter.Node? tsRedirectNode = tsNode.GetChildForField("redirect");
        cIAstNode? fileRedirectNode = this.IsMissing(tsRedirectNode)
                ? null
                : this.ParseChild(tsRedirectNode);
        List<cIAstNode> parts = this.CollectNamedChildren(tsNode);

        return new cCommandSubstitutionNode(syntaxInfo, parts, fileRedirectNode);
    }
}
