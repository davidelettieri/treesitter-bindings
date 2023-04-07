namespace TreeSitter.Bindings;

[NativeTypeName("unsigned int")]
public enum TSParseActionType : uint
{
    TSParseActionTypeShift,
    TSParseActionTypeReduce,
    TSParseActionTypeAccept,
    TSParseActionTypeRecover,
}
