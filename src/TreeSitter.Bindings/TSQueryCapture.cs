namespace TreeSitter.Bindings;

public struct TSQueryCapture
{
    public TSNode node;

    [NativeTypeName("uint32_t")] public uint index;
}