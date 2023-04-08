namespace TreeSitter.Bindings;

public struct TSFieldMapSlice
{
    [NativeTypeName("uint16_t")] public ushort index;

    [NativeTypeName("uint16_t")] public ushort length;
}