namespace TreeSitter.Bindings;

public struct TSFieldMapEntry
{
    [NativeTypeName("TSFieldId")] public ushort field_id;

    [NativeTypeName("uint8_t")] public byte child_index;

    [NativeTypeName("bool")] public byte inherited;
}