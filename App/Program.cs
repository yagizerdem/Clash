using Clash.Ast.Base;
using Clash.Parser;
using Runtime;

var parser = new ClashParser();
cIAstNode rootNode = parser.Parse("echo hit");

Console.WriteLine("Parsing completed.");



Core core = new Core();
core.Run();