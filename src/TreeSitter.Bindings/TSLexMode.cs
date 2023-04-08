namespace TreeSitter.Bindings;

public struct TSLexMode
{
    [NativeTypeName("uint16_t")] public ushort lex_state;

    [NativeTypeName("uint16_t")] public ushort external_lex_state;
}