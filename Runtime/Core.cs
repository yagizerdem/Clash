using Clash.Ast.Base;
using Clash.Ast.Nodes.Stmt;
using Clash.Ast.Visitor;

namespace Runtime;

public class Core
{
    private readonly cIAstNode rootNode;
    public Core(cIAstNode rootNode)
    {
        this.rootNode = rootNode;
    }

    public void Run()
    {
        EvaluationDispatcher dispatcher = new EvaluationDispatcher();
        rootNode.Accept(dispatcher);

    }



}
