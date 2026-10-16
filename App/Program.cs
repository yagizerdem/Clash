using Clash.Ast.Base;
using Clash.Parser;
using Runtime;

var parser = new ClashParser();
cIAstNode rootNode = parser.Parse("echo hit");




Core core = new Core(rootNode);
core.Run();