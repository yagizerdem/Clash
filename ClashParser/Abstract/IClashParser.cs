namespace Clash.Parser.Abstract;


using Clash.Ast.Base;
using TreeSitter;

public interface IClashParser {
    void CheckType(TreeSitter.Node tsNode, string tsTypeName);
    IAstNode Parse(TreeSitter.Node tsNode);
}


