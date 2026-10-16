using Clash.Ast.Base;
using Clash.Parser;
using Runtime;



var parser = new ClashParser();
cIAstNode rootNode = parser.Parse(
@"for i in a b c;
do
    echo $i
done"
);




Core core = new Core(rootNode);
core.Run();