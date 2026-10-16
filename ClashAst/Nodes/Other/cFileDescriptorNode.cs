using Clash.Ast.Base;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Other;

public sealed class cFileDescriptorNode : cBaseAstNode
{
    public cFileDescriptorNode(SyntaxInfo syntax)
        : base(syntax)
    {
    }

    public override T Accept<T>(IVisitor<T> visitor) => visitor.VisitFileDescriptor(this);
}
