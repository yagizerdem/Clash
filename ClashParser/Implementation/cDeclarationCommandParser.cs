using Clash.Ast.Base;
using Clash.Ast.Enums;
using Clash.Ast.Nodes.Stmt;
using Clash.Parser.Abstract;
using TreeSitter;

namespace Clash.Parser.Implementation;

public class cDeclarationCommandParser : ClashBaseParser {

    public cDeclarationCommandParser(string program, TreeSitter.Node node) : base(program, node)
    {
    }

    public override cIAstNode Parse(TreeSitter.Node tsNode) {
        this.CheckType(tsNode, "declaration_command");
        SyntaxInfo syntaxInfo = this.ExtractSyntaxInfo();
        DeclarationKind kind = this.ParseKind(syntaxInfo.Raw);
        List<cIAstNode> arguments = this.CollectNamedChildren(tsNode);
        return new cDeclarationCommandNode(syntaxInfo, kind, arguments);
    }

    private DeclarationKind ParseKind(string raw) {
        string keyword = System.Text.RegularExpressions.Regex.Split(raw.TrimStart(), @"\s+", System.Text.RegularExpressions.RegexOptions.None)[0];
        return keyword switch
        {
            "declare" => DeclarationKind.Declare,
            "export" => DeclarationKind.Export,
            "local" => DeclarationKind.Local,
            "readonly" => DeclarationKind.Readonly,
            "typeset" => DeclarationKind.Typeset,
            _ => throw new InvalidOperationException("Unknown declaration kind: " + keyword),
        };
    }
}
