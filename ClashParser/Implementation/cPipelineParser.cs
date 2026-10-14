using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Nodes.Stmt;
using Clash.Parser.Abstract;
using TreeSitter;

namespace Clash.Parser.Implementation;

public class cPipelineParser : ClashBaseParser {

    public cPipelineParser(string program, TreeSitter.Node node) : base(program, node)
    {
    }

    public override IAstNode Parse(TreeSitter.Node tsNode) {
        this.CheckType(tsNode, "pipeline");
        SyntaxInfo syntaxInfo = this.ExtractSyntaxInfo();
        List<IAstNode> commands = [];
        List<PipeOperator> operators = [];

        for (int i = 0; i < tsNode.Children.Count; i++) {
            TreeSitter.Node child = tsNode.Children[i];
            if (child.IsNamed) {
                commands.Add((StmtNode) this.ParseChild(child));
            } else {
                string raw = this.GetProgramByOffsets(child);
                if (raw.Equals("|")) {
                    operators.Add(PipeOperator.Pipe);
                } else if (raw.Equals("|&")) {
                    operators.Add(PipeOperator.PipeStderr);
                }
            }
        }

        return new PipelineNode(syntaxInfo, commands, operators);
    }
}
