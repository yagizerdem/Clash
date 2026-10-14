using Clash.Ast.Base;
using Clash.Ast.Nodes.PrimaryExpr;
using Clash.Parser.Abstract;
using TreeSitter;

namespace Clash.Parser.Implementation;

public class cCommandSubstitutionParser : ClashBaseParser {

    public cCommandSubstitutionParser(string program, TreeSitter.Node node) : base(program, node)
    {
    }


    public override IAstNode Parse(TreeSitter.Node tsNode) {
        this.CheckType(tsNode, "command_substitution");
        SyntaxInfo syntaxInfo = this.ExtractSyntaxInfo();

        TreeSitter.Node? tsRedirectNode = tsNode.GetChildForField("redirect");
        IAstNode? fileRedirectNode = this.IsMissing(tsRedirectNode)
                ? null
                : this.ParseChild(tsRedirectNode);
        List<IAstNode> parts = this.CollectNamedChildren(tsNode);

        return new CommandSubstitutionNode(syntaxInfo, parts, fileRedirectNode);
    }
}
