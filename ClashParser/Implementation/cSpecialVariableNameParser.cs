using Clash.Ast.Base;
using Clash.Ast.Nodes.Other;
using Clash.Parser.Abstract;
using TreeSitter;

namespace Clash.Parser.Implementation;

public class cSpecialVariableNameParser : ClashBaseParser {

    public cSpecialVariableNameParser(string program, TreeSitter.Node node) : base(program, node)
    {
    }

    public override IAstNode Parse(TreeSitter.Node tsNode) {
        this.CheckType(tsNode, "special_variable_name");
        SyntaxInfo syntaxInfo = this.ExtractSyntaxInfo();
        string variableName = this.GetProgramByOffsets();
        VariableNameNode node = new VariableNameNode(syntaxInfo, variableName);
        return node;
    }
}
