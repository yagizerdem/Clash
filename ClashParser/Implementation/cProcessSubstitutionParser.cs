using Clash.Ast.Base;
using Clash.Ast.Nodes.PrimaryExpr;
using Clash.Parser.Abstract;
using TreeSitter;

namespace Clash.Parser.Implementation;

public class cProcessSubstitutionParser : ClashBaseParser {

    public cProcessSubstitutionParser(string program, TreeSitter.Node node) : base(program, node)
    {
    }

    public override cIAstNode Parse(TreeSitter.Node tsNode) {
        this.CheckType(tsNode, "process_substitution");
        SyntaxInfo syntaxInfo = this.ExtractSyntaxInfo();
        List<cIAstNode> parts = this.CollectNamedChildren(tsNode);
        return new cProcessSubstitutionNode(syntaxInfo, parts);
    }
}
