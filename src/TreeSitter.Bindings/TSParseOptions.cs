namespace TreeSitter.Bindings;

public unsafe partial struct TSParseOptions
{
    public void* payload;

    [NativeTypeName("bool (*)(TSParseState *)")]
    public delegate* unmanaged[Cdecl]<TSParseState*, byte> progress_callback;
}
