namespace TreeSitter.Bindings;

public unsafe partial struct TSParseState
{
    public void* payload;

    [NativeTypeName("uint32_t")]
    public uint current_byte_offset;

    [NativeTypeName("bool")]
    public byte has_error;
}
