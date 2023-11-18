using System.Diagnostics;
using ClangSharp.Interop;
using TreeSitter.Bindings;
using static TreeSitter.Bindings.Json.TSBindingsJson;
using static TreeSitter.Bindings.EmbdeddedTemplate.TSBindingsEmbdeddedTemplate;
using static TreeSitter.Bindings.Html.TSBindingsHtml;
using static TreeSitter.Bindings.Ruby.TSBindingsRuby;
using static TreeSitter.Bindings.TSBindings;

unsafe
{
    Console.WriteLine("-- Json sample --");
    JsonSample();
    Console.WriteLine("-- Multi language sample --");
    MultiLanguageDocumentSample();

    void JsonSample()
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

    void MultiLanguageDocumentSample()
    {
        var parser = parser_new();
        parser_set_language(parser, tree_sitter_embedded_template());

        MarshaledString sourceCode =
            new MarshaledString(
                "<ul>\n  <% people.each do |person| %>\n    <li><%= person.name %></li>\n  <% end %>\n</ul>");
        TSTree* tree = parser_parse_string(
            parser,
            null,
            sourceCode,
            (uint) sourceCode.Length
        );

        TSNode erbRootNode = tree_root_node(tree);
        var childCount = node_child_count(erbRootNode);
        TSRange[] htmlRanges = new TSRange[childCount];
        TSRange[] rubyRanges = new TSRange[childCount];
        uint htmlRangesCount = 0;
        uint rubyRangesCount = 0;

        for (uint i = 0; i < childCount; i++)
        {
            TSNode node = node_child(erbRootNode, i);

            if (new string(node_type(node)) == "content")
            {
                var htmlRange = new TSRange()
                {
                    start_point = node_start_point(node),
                    end_point = node_end_point(node),
                    start_byte = node_start_byte(node),
                    end_byte = node_end_byte(node)
                };

                htmlRanges[htmlRangesCount++] = htmlRange;
            }
            else
            {
                TSNode codeNode = node_named_child(node, 0);
                var rubyRange = new TSRange()
                {
                    start_point = node_start_point(codeNode),
                    end_point = node_end_point(codeNode),
                    start_byte = node_start_byte(codeNode),
                    end_byte = node_end_byte(codeNode)
                };
                rubyRanges[rubyRangesCount++] = rubyRange;
            }
        }

        fixed (TSRange* ph = &htmlRanges[0])
        fixed (TSRange* pr = &rubyRanges[0])
        {
            parser_set_language(parser, tree_sitter_html());
            parser_set_included_ranges(parser, ph, htmlRangesCount);
            TSTree* htmlTree = parser_parse_string(parser, null, sourceCode, (uint) sourceCode.Length);
            TSNode htmlRootNode = tree_root_node(htmlTree);
            
            parser_set_language(parser, tree_sitter_ruby());
            parser_set_included_ranges(parser, pr, rubyRangesCount);
            TSTree* rubyTree = parser_parse_string(parser, null, sourceCode, (uint) sourceCode.Length);
            TSNode rubyRootNode = tree_root_node(rubyTree);

            string erbSexp = new string(node_string(erbRootNode));
            string htmlSexp = new string(node_string(htmlRootNode));
            string rubySexp = new string(node_string(rubyRootNode));
            
            Console.WriteLine(erbSexp);
            Console.WriteLine(htmlSexp);
            Console.WriteLine(rubySexp);
        }
    }
}