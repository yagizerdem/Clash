using Clash.Ast.Base;
using Clash.Ast.Nodes.Other;
using Clash.Parser.Abstract;
using TreeSitter;

namespace Clash.Parser.Implementation;

public class cElifClauseParser : ClashBaseParser {
    public cElifClauseParser(string program, TreeSitter.Node node) : base(program, node)
    {
    }

    public override IAstNode Parse(TreeSitter.Node tsNode) {
        this.CheckType(tsNode, "elif_clause");
        int thenOffset = this.FindThenOffset(tsNode);
        List<IAstNode> condition = [];
        List<IAstNode> thenBranch = [];

        for (int i = 0; i < tsNode.NamedChildren.Count; i++) {
            TreeSitter.Node child = tsNode.NamedChildren[i];
            StmtNode statement = (StmtNode) this.ParseChild(child);
            if (child.StartIndex < thenOffset) {
                condition.Add(statement);
            } else {
                thenBranch.Add(statement);
            }
        }

        return new ElifClauseNode(this.ExtractSyntaxInfo(), condition, thenBranch);
    }

    private int FindThenOffset(TreeSitter.Node tsNode) {
        for (int i = 0; i < tsNode.Children.Count; i++) {
            TreeSitter.Node child = tsNode.Children[i];
            if (this.GetProgramByOffsets(child).Equals("then")) {
                return child.EndIndex;
            }
        }
        throw new InvalidOperationException("elif_clause is missing then");
    }
}
