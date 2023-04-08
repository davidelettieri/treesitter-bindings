namespace TreeSitter.Bindings;

[NativeTypeName("unsigned int")]
public enum TSSymbolType : uint
{
    TSSymbolTypeRegular,
    TSSymbolTypeAnonymous,
    TSSymbolTypeAuxiliary
}