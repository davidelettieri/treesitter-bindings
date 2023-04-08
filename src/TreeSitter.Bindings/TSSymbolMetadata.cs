namespace TreeSitter.Bindings;

public struct TSSymbolMetadata
{
    [NativeTypeName("bool")] public byte visible;

    [NativeTypeName("bool")] public byte named;

    [NativeTypeName("bool")] public byte supertype;
}