using System.Diagnostics;
using ClangSharp.Interop;
using static TreeSitter.Bindings.Json.TSBindingsJson;
using static TreeSitter.Bindings.TSBindings;

unsafe
{
    var parser = parser_new();

    parser_set_language(parser, tree_sitter_json());

    MarshaledString sourceCode = new MarshaledString("[1, null]");
    var tree = parser_parse_string(
        parser,
        null,
        sourceCode,
        (uint) sourceCode.Length
    );

    var rootNode = tree_root_node(tree);
    var arrayNode = node_named_child(rootNode, 0);
    var numberNode = node_named_child(arrayNode, 0);

    Debug.Assert(new string(node_type(rootNode)) == "document");
    Debug.Assert(new string(node_type(arrayNode)) == "array");
    Debug.Assert(new string(node_type(numberNode)) == "number");

    Debug.Assert(node_child_count(rootNode) == 1);
    Debug.Assert(node_child_count(arrayNode) == 5);
    Debug.Assert(node_named_child_count(arrayNode) == 2);
    Debug.Assert(node_child_count(numberNode) == 0);

    var stringRep = node_string(rootNode);

    Console.WriteLine("Syntax tree: {0}", new string(stringRep));
    
    tree_delete(tree);
    parser_delete(parser);
}