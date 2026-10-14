using TreeSitter;

public interface IClashParser {
    void CheckType(TreeSitter.Node tsNode, string tsTypeName);
    T Parse<T>(TreeSitter.Node tsNode);
}


