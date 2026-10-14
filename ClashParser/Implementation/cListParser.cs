using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Nodes.Stmt;
using Clash.Parser.Abstract;
using TreeSitter;

namespace Clash.Parser.Implementation;

public class cListParser : ClashBaseParser {

    public cListParser(string program, TreeSitter.Node node) : base(program, node)
    {
    }

    public override cIAstNode Parse(TreeSitter.Node tsNode) {
        this.CheckType(tsNode, "list");
        SyntaxInfo syntaxInfo = this.ExtractSyntaxInfo();
        List<cIAstNode> statements = [];
        List<ListOperator> operators = [];

        for (int i = 0; i < tsNode.Children.Count; i++) {
            TreeSitter.Node child = tsNode.Children[i];
            if (child.IsNamed) {
                statements.Add(this.ParseChild(child));
            } else {
                ListOperator? @operator = this.ParseOperator(this.GetProgramByOffsets(child));
                if (@operator != null) {
                    operators.Add(@operator.Value);
                }
            }
        }

        return new cListNode(syntaxInfo, statements, operators);
    }

    private ListOperator? ParseOperator(string raw) {
        return raw switch
        {
            ";" => ListOperator.Sequence,
            "&" => ListOperator.Background,
            "&&" => ListOperator.LogicalAnd,
            "||" => ListOperator.LogicalOr,
            _ => null,
        };
    }
}
