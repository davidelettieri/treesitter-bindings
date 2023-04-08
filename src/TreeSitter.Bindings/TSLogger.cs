namespace TreeSitter.Bindings;

public unsafe struct TSLogger
{
    public void* payload;

    [NativeTypeName("void (*)(void *, TSLogType, const char *)")]
    public delegate* unmanaged[Cdecl]<void*, TSLogType, sbyte*, void> log;
}