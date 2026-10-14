using Clash.Ast.Base;
using Clash.Parser;

var parser = new ClashParser();
cIAstNode rootNode = parser.Parse("echo hit");


Console.WriteLine("Parsing completed.");
