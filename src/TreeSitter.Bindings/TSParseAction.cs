using System.Runtime.InteropServices;

namespace TreeSitter.Bindings;

[StructLayout(LayoutKind.Explicit)]
public partial struct TSParseAction
{
    [FieldOffset(0)] [NativeTypeName("struct (anonymous struct at tree-sitter/lib/include/tree_sitter/parser.h:61:3)")]
    public _shift_e__Struct shift;

    [FieldOffset(0)] [NativeTypeName("struct (anonymous struct at tree-sitter/lib/include/tree_sitter/parser.h:67:3)")]
    public _reduce_e__Struct reduce;

    [FieldOffset(0)] [NativeTypeName("uint8_t")]
    public byte type;

    public struct _shift_e__Struct
    {
        [NativeTypeName("uint8_t")] public byte type;

        [NativeTypeName("TSStateId")] public ushort state;

        [NativeTypeName("bool")] public byte extra;

        [NativeTypeName("bool")] public byte repetition;
    }

    public struct _reduce_e__Struct
    {
        [NativeTypeName("uint8_t")] public byte type;

        [NativeTypeName("uint8_t")] public byte child_count;

        [NativeTypeName("TSSymbol")] public ushort symbol;

        [NativeTypeName("int16_t")] public short dynamic_precedence;

        [NativeTypeName("uint16_t")] public ushort production_id;
    }
}