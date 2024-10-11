using System.Runtime.InteropServices;

namespace TreeSitter.Bindings.Json;

public static unsafe partial class TSBindingsJson
{
    [DllImport("libtree-sitter-json", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const TSLanguage *")]
    public static extern TSLanguage* tree_sitter_json();
}
