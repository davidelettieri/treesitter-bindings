using System.Runtime.InteropServices;

namespace TreeSitter.Bindings.Ruby;

public static unsafe partial class TSBindingsRuby
{
    [DllImport("libtree-sitter-ruby", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern TSLanguage* tree_sitter_ruby();
}
