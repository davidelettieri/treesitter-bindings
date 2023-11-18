namespace TreeSitter.Bindings;

public static partial class TSBindingsParser
{
    [NativeTypeName("#define ts_builtin_sym_error ((TSSymbol)-1)")]
    public const ushort ts_builtin_sym_error = unchecked((ushort)(-1));

    [NativeTypeName("#define ts_builtin_sym_end 0")]
    public const int ts_builtin_sym_end = 0;

    [NativeTypeName("#define TREE_SITTER_SERIALIZATION_BUFFER_SIZE 1024")]
    public const int TREE_SITTER_SERIALIZATION_BUFFER_SIZE = 1024;
}
