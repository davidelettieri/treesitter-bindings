using System.Runtime.InteropServices;

namespace TreeSitter.Bindings.Json;

public static unsafe partial class Methods
{
    [DllImport("libtree-sitter-json", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern TSLanguage* tree_sitter_json();
}
