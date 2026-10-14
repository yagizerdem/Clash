using Clash.Ast.Base;
using Clash.Ast.Nodes.Expr;
using Clash.Parser.Abstract;
using TreeSitter;

namespace Clash.Parser.Implementation;

public class cConcatenationParser : ClashBaseParser {

    public cConcatenationParser(string program, TreeSitter.Node node) : base(program, node)
    {
    }

    public override IAstNode Parse(TreeSitter.Node tsNode) {
        this.CheckType(tsNode, "concatenation");
        SyntaxInfo syntaxInfo = this.ExtractSyntaxInfo();
        List<IAstNode> parts = this.CollectNamedChildren(tsNode);
        return new ConcatenationNode(syntaxInfo, parts);
    }
}
