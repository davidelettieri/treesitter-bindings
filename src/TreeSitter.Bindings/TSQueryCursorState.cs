namespace TreeSitter.Bindings;

public unsafe partial struct TSQueryCursorState
{
    public void* payload;

    [NativeTypeName("uint32_t")]
    public uint current_byte_offset;
}
