using System.Runtime.InteropServices;

namespace TreeSitter.Bindings.Html;

public static unsafe partial class TSBindingsHtml
{
    [DllImport("libtree-sitter-html", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const TSLanguage *")]
    public static extern TSLanguage* tree_sitter_html();
}
