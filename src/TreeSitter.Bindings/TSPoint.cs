namespace TreeSitter.Bindings;

public struct TSPoint
{
    [NativeTypeName("uint32_t")] public uint row;

    [NativeTypeName("uint32_t")] public uint column;
}