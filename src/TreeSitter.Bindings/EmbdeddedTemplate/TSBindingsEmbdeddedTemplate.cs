using System.Runtime.InteropServices;

namespace TreeSitter.Bindings.EmbdeddedTemplate;

public static unsafe partial class TSBindingsEmbdeddedTemplate
{
    [DllImport("tree-sitter-embedded-template", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const TSLanguage *")]
    public static extern TSLanguage* tree_sitter_embedded_template();
}
