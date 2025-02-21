namespace TreeSitter.Bindings;

public unsafe partial struct TSQueryCursorOptions
{
    public void* payload;

    [NativeTypeName("bool (*)(TSQueryCursorState *)")]
    public delegate* unmanaged[Cdecl]<TSQueryCursorState*, byte> progress_callback;
}
