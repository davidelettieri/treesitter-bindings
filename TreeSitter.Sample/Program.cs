using TreeSitter.Bindings.Helpers;
using static TreeSitter.Bindings.Json.Methods;
using static TreeSitter.Bindings.Methods;

unsafe
{
    var parser = ts_parser_new();
    ts_parser_set_language(parser, tree_sitter_json());

    var source = new MarshaledString("[1, null]");

    var tree = ts_parser_parse_string(parser, null, source, Convert.ToUInt32(source.Length));

    var rootNode = ts_tree_root_node(tree);

    var textRepresentation = ts_node_string(rootNode);

    var s = new String(textRepresentation);
    
}