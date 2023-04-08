using TreeSitter.Bindings.Helpers;
using static TreeSitter.Bindings.Json.TSBindingsJson;
using static TreeSitter.Bindings.TSBindings;

unsafe
{
    var parser = parser_new();
    parser_set_language(parser, tree_sitter_json());

    var source = new MarshaledString("[1, null]");

    var tree = parser_parse_string(parser, null, source, Convert.ToUInt32(source.Length));

    var rootNode = tree_root_node(tree);

    var textRepresentation = node_string(rootNode);

    var s = new String(textRepresentation);
    Console.WriteLine(s);
}