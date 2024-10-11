namespace TreeSitter.Bindings;

[NativeTypeName("unsigned int")]
public enum TSWasmErrorKind : uint
{
    TSWasmErrorKindNone = 0,
    TSWasmErrorKindParse,
    TSWasmErrorKindCompile,
    TSWasmErrorKindInstantiate,
    TSWasmErrorKindAllocate,
}
