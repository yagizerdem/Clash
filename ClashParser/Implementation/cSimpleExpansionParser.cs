using Clash.Ast.Base;
using Clash.Ast.Nodes.PrimaryExpr;
using Clash.Parser.Abstract;
using TreeSitter;

namespace Clash.Parser.Implementation;

public class cSimpleExpansionParser : ClashBaseParser {

    public cSimpleExpansionParser(string program, TreeSitter.Node node) : base(program, node)
    {
    }


    public override IAstNode Parse(TreeSitter.Node tsNode) {
        this.CheckType(tsNode, "simple_expansion");
        SyntaxInfo syntaxInfo = this.ExtractSyntaxInfo();

        if(tsNode.NamedChildren.Count != 1) {
            throw new InvalidOperationException("must has 1 child");
        }

        TreeSitter.Node childTsNode = tsNode.NamedChildren[0];
        ClashBaseParser parser = this.Dispatcher(childTsNode);
        IAstNode identifier = parser.Parse(childTsNode);

        SimpleExpansionNode node = new SimpleExpansionNode(syntaxInfo, identifier);
        return node;
    }
}
