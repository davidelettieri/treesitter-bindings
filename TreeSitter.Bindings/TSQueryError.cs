namespace TreeSitter.Bindings;

[NativeTypeName("unsigned int")]
public enum TSQueryError : uint
{
    TSQueryErrorNone = 0,
    TSQueryErrorSyntax,
    TSQueryErrorNodeType,
    TSQueryErrorField,
    TSQueryErrorCapture,
    TSQueryErrorStructure,
    TSQueryErrorLanguage,
}
