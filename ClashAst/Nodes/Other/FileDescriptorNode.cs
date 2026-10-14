using Clash.Ast.Base;
using Clash.Ast.Visitor;

namespace Clash.Ast.Nodes.Other;

public sealed class FileDescriptorNode : BaseAstNode
{
    public FileDescriptorNode(SyntaxInfo syntax)
        : base(syntax)
    {
    }

    public override T Accept<T>(IVisitor visitor) => visitor.VisitFileDescriptor<T>(this);
}
