using System.Runtime.InteropServices;

namespace TreeSitter.Bindings;

public static unsafe class TSBindings
{
    [NativeTypeName("#define TREE_SITTER_LANGUAGE_VERSION 14")]
    public const int TREE_SITTER_LANGUAGE_VERSION = 14;

    [NativeTypeName("#define TREE_SITTER_MIN_COMPATIBLE_LANGUAGE_VERSION 13")]
    public const int TREE_SITTER_MIN_COMPATIBLE_LANGUAGE_VERSION = 13;

    [NativeTypeName("#define ts_builtin_sym_error ((TSSymbol)-1)")]
    public const ushort ts_builtin_sym_error = unchecked((ushort) -1);

    [NativeTypeName("#define ts_builtin_sym_end 0")]
    public const int ts_builtin_sym_end = 0;

    [NativeTypeName("#define TREE_SITTER_SERIALIZATION_BUFFER_SIZE 1024")]
    public const int TREE_SITTER_SERIALIZATION_BUFFER_SIZE = 1024;

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ts_parser_new",
        ExactSpelling = true)]
    public static extern TSParser* parser_new();

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ts_parser_delete",
        ExactSpelling = true)]
    public static extern void parser_delete(TSParser* parser);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ts_parser_set_language",
        ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte parser_set_language(TSParser* self,
        [NativeTypeName("const TSLanguage *")] TSLanguage* language);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ts_parser_language",
        ExactSpelling = true)]
    [return: NativeTypeName("const TSLanguage *")]
    public static extern TSLanguage* parser_language([NativeTypeName("const TSParser *")] TSParser* self);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl,
        EntryPoint = "ts_parser_set_included_ranges", ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte parser_set_included_ranges(TSParser* self,
        [NativeTypeName("const TSRange *")] TSRange* ranges, [NativeTypeName("uint32_t")] uint length);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ts_parser_included_ranges",
        ExactSpelling = true)]
    [return: NativeTypeName("const TSRange *")]
    public static extern TSRange* parser_included_ranges([NativeTypeName("const TSParser *")] TSParser* self,
        [NativeTypeName("uint32_t *")] uint* length);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ts_parser_parse",
        ExactSpelling = true)]
    public static extern TSTree* parser_parse(TSParser* self, [NativeTypeName("const TSTree *")] TSTree* old_tree,
        TSInput input);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ts_parser_parse_string",
        ExactSpelling = true)]
    public static extern TSTree* parser_parse_string(TSParser* self,
        [NativeTypeName("const TSTree *")] TSTree* old_tree, [NativeTypeName("const char *")] sbyte* @string,
        [NativeTypeName("uint32_t")] uint length);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl,
        EntryPoint = "ts_parser_parse_string_encoding", ExactSpelling = true)]
    public static extern TSTree* parser_parse_string_encoding(TSParser* self,
        [NativeTypeName("const TSTree *")] TSTree* old_tree, [NativeTypeName("const char *")] sbyte* @string,
        [NativeTypeName("uint32_t")] uint length, TSInputEncoding encoding);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ts_parser_reset",
        ExactSpelling = true)]
    public static extern void parser_reset(TSParser* self);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl,
        EntryPoint = "ts_parser_set_timeout_micros", ExactSpelling = true)]
    public static extern void parser_set_timeout_micros(TSParser* self, [NativeTypeName("uint64_t")] nuint timeout);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ts_parser_timeout_micros",
        ExactSpelling = true)]
    [return: NativeTypeName("uint64_t")]
    public static extern nuint parser_timeout_micros([NativeTypeName("const TSParser *")] TSParser* self);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl,
        EntryPoint = "ts_parser_set_cancellation_flag", ExactSpelling = true)]
    public static extern void parser_set_cancellation_flag(TSParser* self,
        [NativeTypeName("const size_t *")] nuint* flag);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl,
        EntryPoint = "ts_parser_cancellation_flag", ExactSpelling = true)]
    [return: NativeTypeName("const size_t *")]
    public static extern nuint* parser_cancellation_flag([NativeTypeName("const TSParser *")] TSParser* self);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ts_parser_set_logger",
        ExactSpelling = true)]
    public static extern void parser_set_logger(TSParser* self, TSLogger logger);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ts_parser_logger",
        ExactSpelling = true)]
    public static extern TSLogger parser_logger([NativeTypeName("const TSParser *")] TSParser* self);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ts_parser_print_dot_graphs",
        ExactSpelling = true)]
    public static extern void parser_print_dot_graphs(TSParser* self, int file);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ts_tree_copy",
        ExactSpelling = true)]
    public static extern TSTree* tree_copy([NativeTypeName("const TSTree *")] TSTree* self);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ts_tree_delete",
        ExactSpelling = true)]
    public static extern void tree_delete(TSTree* self);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ts_tree_root_node",
        ExactSpelling = true)]
    public static extern TSNode tree_root_node([NativeTypeName("const TSTree *")] TSTree* self);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl,
        EntryPoint = "ts_tree_root_node_with_offset", ExactSpelling = true)]
    public static extern TSNode tree_root_node_with_offset([NativeTypeName("const TSTree *")] TSTree* self,
        [NativeTypeName("uint32_t")] uint offset_bytes, TSPoint offset_point);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ts_tree_language",
        ExactSpelling = true)]
    [return: NativeTypeName("const TSLanguage *")]
    public static extern TSLanguage* tree_language([NativeTypeName("const TSTree *")] TSTree* param0);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ts_tree_included_ranges",
        ExactSpelling = true)]
    public static extern TSRange* tree_included_ranges([NativeTypeName("const TSTree *")] TSTree* param0,
        [NativeTypeName("uint32_t *")] uint* length);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ts_tree_edit",
        ExactSpelling = true)]
    public static extern void tree_edit(TSTree* self, [NativeTypeName("const TSInputEdit *")] TSInputEdit* edit);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ts_tree_get_changed_ranges",
        ExactSpelling = true)]
    public static extern TSRange* tree_get_changed_ranges([NativeTypeName("const TSTree *")] TSTree* old_tree,
        [NativeTypeName("const TSTree *")] TSTree* new_tree, [NativeTypeName("uint32_t *")] uint* length);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ts_tree_print_dot_graph",
        ExactSpelling = true)]
    public static extern void tree_print_dot_graph([NativeTypeName("const TSTree *")] TSTree* param0,
        int file_descriptor);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ts_node_type",
        ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* node_type(TSNode param0);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ts_node_symbol",
        ExactSpelling = true)]
    [return: NativeTypeName("TSSymbol")]
    public static extern ushort node_symbol(TSNode param0);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ts_node_start_byte",
        ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint node_start_byte(TSNode param0);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ts_node_start_point",
        ExactSpelling = true)]
    public static extern TSPoint node_start_point(TSNode param0);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ts_node_end_byte",
        ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint node_end_byte(TSNode param0);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ts_node_end_point",
        ExactSpelling = true)]
    public static extern TSPoint node_end_point(TSNode param0);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ts_node_string",
        ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* node_string(TSNode param0);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ts_node_is_null",
        ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte node_is_null(TSNode param0);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ts_node_is_named",
        ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte node_is_named(TSNode param0);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ts_node_is_missing",
        ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte node_is_missing(TSNode param0);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ts_node_is_extra",
        ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte node_is_extra(TSNode param0);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ts_node_has_changes",
        ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte node_has_changes(TSNode param0);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ts_node_has_error",
        ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte node_has_error(TSNode param0);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ts_node_parent",
        ExactSpelling = true)]
    public static extern TSNode node_parent(TSNode param0);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ts_node_child",
        ExactSpelling = true)]
    public static extern TSNode node_child(TSNode param0, [NativeTypeName("uint32_t")] uint param1);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl,
        EntryPoint = "ts_node_field_name_for_child", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* node_field_name_for_child(TSNode param0, [NativeTypeName("uint32_t")] uint param1);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ts_node_child_count",
        ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint node_child_count(TSNode param0);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ts_node_named_child",
        ExactSpelling = true)]
    public static extern TSNode node_named_child(TSNode param0, [NativeTypeName("uint32_t")] uint param1);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ts_node_named_child_count",
        ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint node_named_child_count(TSNode param0);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl,
        EntryPoint = "ts_node_child_by_field_name", ExactSpelling = true)]
    public static extern TSNode node_child_by_field_name(TSNode self,
        [NativeTypeName("const char *")] sbyte* field_name, [NativeTypeName("uint32_t")] uint field_name_length);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ts_node_child_by_field_id",
        ExactSpelling = true)]
    public static extern TSNode node_child_by_field_id(TSNode param0, [NativeTypeName("TSFieldId")] ushort param1);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ts_node_next_sibling",
        ExactSpelling = true)]
    public static extern TSNode node_next_sibling(TSNode param0);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ts_node_prev_sibling",
        ExactSpelling = true)]
    public static extern TSNode node_prev_sibling(TSNode param0);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ts_node_next_named_sibling",
        ExactSpelling = true)]
    public static extern TSNode node_next_named_sibling(TSNode param0);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ts_node_prev_named_sibling",
        ExactSpelling = true)]
    public static extern TSNode node_prev_named_sibling(TSNode param0);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl,
        EntryPoint = "ts_node_first_child_for_byte", ExactSpelling = true)]
    public static extern TSNode node_first_child_for_byte(TSNode param0, [NativeTypeName("uint32_t")] uint param1);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl,
        EntryPoint = "ts_node_first_named_child_for_byte", ExactSpelling = true)]
    public static extern TSNode
        node_first_named_child_for_byte(TSNode param0, [NativeTypeName("uint32_t")] uint param1);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl,
        EntryPoint = "ts_node_descendant_for_byte_range", ExactSpelling = true)]
    public static extern TSNode node_descendant_for_byte_range(TSNode param0, [NativeTypeName("uint32_t")] uint param1,
        [NativeTypeName("uint32_t")] uint param2);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl,
        EntryPoint = "ts_node_descendant_for_point_range", ExactSpelling = true)]
    public static extern TSNode node_descendant_for_point_range(TSNode param0, TSPoint param1, TSPoint param2);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl,
        EntryPoint = "ts_node_named_descendant_for_byte_range", ExactSpelling = true)]
    public static extern TSNode node_named_descendant_for_byte_range(TSNode param0,
        [NativeTypeName("uint32_t")] uint param1, [NativeTypeName("uint32_t")] uint param2);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl,
        EntryPoint = "ts_node_named_descendant_for_point_range", ExactSpelling = true)]
    public static extern TSNode node_named_descendant_for_point_range(TSNode param0, TSPoint param1, TSPoint param2);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ts_node_edit",
        ExactSpelling = true)]
    public static extern void node_edit(TSNode* param0, [NativeTypeName("const TSInputEdit *")] TSInputEdit* param1);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ts_node_eq",
        ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte node_eq(TSNode param0, TSNode param1);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ts_tree_cursor_new",
        ExactSpelling = true)]
    public static extern TSTreeCursor tree_cursor_new(TSNode param0);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ts_tree_cursor_delete",
        ExactSpelling = true)]
    public static extern void tree_cursor_delete(TSTreeCursor* param0);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ts_tree_cursor_reset",
        ExactSpelling = true)]
    public static extern void tree_cursor_reset(TSTreeCursor* param0, TSNode param1);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl,
        EntryPoint = "ts_tree_cursor_current_node", ExactSpelling = true)]
    public static extern TSNode tree_cursor_current_node([NativeTypeName("const TSTreeCursor *")] TSTreeCursor* param0);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl,
        EntryPoint = "ts_tree_cursor_current_field_name", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* tree_cursor_current_field_name(
        [NativeTypeName("const TSTreeCursor *")] TSTreeCursor* param0);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl,
        EntryPoint = "ts_tree_cursor_current_field_id", ExactSpelling = true)]
    [return: NativeTypeName("TSFieldId")]
    public static extern ushort tree_cursor_current_field_id(
        [NativeTypeName("const TSTreeCursor *")] TSTreeCursor* param0);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ts_tree_cursor_goto_parent",
        ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte tree_cursor_goto_parent(TSTreeCursor* param0);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl,
        EntryPoint = "ts_tree_cursor_goto_next_sibling", ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte tree_cursor_goto_next_sibling(TSTreeCursor* param0);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl,
        EntryPoint = "ts_tree_cursor_goto_first_child", ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte tree_cursor_goto_first_child(TSTreeCursor* param0);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl,
        EntryPoint = "ts_tree_cursor_goto_first_child_for_byte", ExactSpelling = true)]
    [return: NativeTypeName("int64_t")]
    public static extern nint tree_cursor_goto_first_child_for_byte(TSTreeCursor* param0,
        [NativeTypeName("uint32_t")] uint param1);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl,
        EntryPoint = "ts_tree_cursor_goto_first_child_for_point", ExactSpelling = true)]
    [return: NativeTypeName("int64_t")]
    public static extern nint tree_cursor_goto_first_child_for_point(TSTreeCursor* param0, TSPoint param1);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ts_tree_cursor_copy",
        ExactSpelling = true)]
    public static extern TSTreeCursor tree_cursor_copy([NativeTypeName("const TSTreeCursor *")] TSTreeCursor* param0);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ts_query_new",
        ExactSpelling = true)]
    public static extern TSQuery* query_new([NativeTypeName("const TSLanguage *")] TSLanguage* language,
        [NativeTypeName("const char *")] sbyte* source, [NativeTypeName("uint32_t")] uint source_len,
        [NativeTypeName("uint32_t *")] uint* error_offset, TSQueryError* error_type);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ts_query_delete",
        ExactSpelling = true)]
    public static extern void query_delete(TSQuery* param0);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ts_query_pattern_count",
        ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint query_pattern_count([NativeTypeName("const TSQuery *")] TSQuery* param0);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ts_query_capture_count",
        ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint query_capture_count([NativeTypeName("const TSQuery *")] TSQuery* param0);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ts_query_string_count",
        ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint query_string_count([NativeTypeName("const TSQuery *")] TSQuery* param0);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl,
        EntryPoint = "ts_query_start_byte_for_pattern", ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint query_start_byte_for_pattern([NativeTypeName("const TSQuery *")] TSQuery* param0,
        [NativeTypeName("uint32_t")] uint param1);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl,
        EntryPoint = "ts_query_predicates_for_pattern", ExactSpelling = true)]
    [return: NativeTypeName("const TSQueryPredicateStep *")]
    public static extern TSQueryPredicateStep* query_predicates_for_pattern(
        [NativeTypeName("const TSQuery *")] TSQuery* self, [NativeTypeName("uint32_t")] uint pattern_index,
        [NativeTypeName("uint32_t *")] uint* length);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ts_query_is_pattern_rooted",
        ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte query_is_pattern_rooted([NativeTypeName("const TSQuery *")] TSQuery* self,
        [NativeTypeName("uint32_t")] uint pattern_index);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl,
        EntryPoint = "ts_query_is_pattern_non_local", ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte query_is_pattern_non_local([NativeTypeName("const TSQuery *")] TSQuery* self,
        [NativeTypeName("uint32_t")] uint pattern_index);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl,
        EntryPoint = "ts_query_is_pattern_guaranteed_at_step", ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte query_is_pattern_guaranteed_at_step([NativeTypeName("const TSQuery *")] TSQuery* self,
        [NativeTypeName("uint32_t")] uint byte_offset);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl,
        EntryPoint = "ts_query_capture_name_for_id", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* query_capture_name_for_id([NativeTypeName("const TSQuery *")] TSQuery* param0,
        [NativeTypeName("uint32_t")] uint id, [NativeTypeName("uint32_t *")] uint* length);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl,
        EntryPoint = "ts_query_capture_quantifier_for_id", ExactSpelling = true)]
    public static extern TSQuantifier query_capture_quantifier_for_id(
        [NativeTypeName("const TSQuery *")] TSQuery* param0, [NativeTypeName("uint32_t")] uint pattern_id,
        [NativeTypeName("uint32_t")] uint capture_id);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl,
        EntryPoint = "ts_query_string_value_for_id", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* query_string_value_for_id([NativeTypeName("const TSQuery *")] TSQuery* param0,
        [NativeTypeName("uint32_t")] uint id, [NativeTypeName("uint32_t *")] uint* length);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ts_query_disable_capture",
        ExactSpelling = true)]
    public static extern void query_disable_capture(TSQuery* param0, [NativeTypeName("const char *")] sbyte* param1,
        [NativeTypeName("uint32_t")] uint param2);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ts_query_disable_pattern",
        ExactSpelling = true)]
    public static extern void query_disable_pattern(TSQuery* param0, [NativeTypeName("uint32_t")] uint param1);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ts_query_cursor_new",
        ExactSpelling = true)]
    public static extern TSQueryCursor* query_cursor_new();

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ts_query_cursor_delete",
        ExactSpelling = true)]
    public static extern void query_cursor_delete(TSQueryCursor* param0);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ts_query_cursor_exec",
        ExactSpelling = true)]
    public static extern void query_cursor_exec(TSQueryCursor* param0,
        [NativeTypeName("const TSQuery *")] TSQuery* param1, TSNode param2);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl,
        EntryPoint = "ts_query_cursor_did_exceed_match_limit", ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte query_cursor_did_exceed_match_limit(
        [NativeTypeName("const TSQueryCursor *")] TSQueryCursor* param0);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl,
        EntryPoint = "ts_query_cursor_match_limit", ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint query_cursor_match_limit([NativeTypeName("const TSQueryCursor *")] TSQueryCursor* param0);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl,
        EntryPoint = "ts_query_cursor_set_match_limit", ExactSpelling = true)]
    public static extern void query_cursor_set_match_limit(TSQueryCursor* param0,
        [NativeTypeName("uint32_t")] uint param1);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl,
        EntryPoint = "ts_query_cursor_set_byte_range", ExactSpelling = true)]
    public static extern void query_cursor_set_byte_range(TSQueryCursor* param0,
        [NativeTypeName("uint32_t")] uint param1, [NativeTypeName("uint32_t")] uint param2);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl,
        EntryPoint = "ts_query_cursor_set_point_range", ExactSpelling = true)]
    public static extern void query_cursor_set_point_range(TSQueryCursor* param0, TSPoint param1, TSPoint param2);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ts_query_cursor_next_match",
        ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte query_cursor_next_match(TSQueryCursor* param0, TSQueryMatch* match);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl,
        EntryPoint = "ts_query_cursor_remove_match", ExactSpelling = true)]
    public static extern void query_cursor_remove_match(TSQueryCursor* param0, [NativeTypeName("uint32_t")] uint id);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl,
        EntryPoint = "ts_query_cursor_next_capture", ExactSpelling = true)]
    [return: NativeTypeName("bool")]
    public static extern byte query_cursor_next_capture(TSQueryCursor* param0, TSQueryMatch* match,
        [NativeTypeName("uint32_t *")] uint* capture_index);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ts_language_symbol_count",
        ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint language_symbol_count([NativeTypeName("const TSLanguage *")] TSLanguage* param0);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ts_language_symbol_name",
        ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* language_symbol_name([NativeTypeName("const TSLanguage *")] TSLanguage* param0,
        [NativeTypeName("TSSymbol")] ushort param1);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl,
        EntryPoint = "ts_language_symbol_for_name", ExactSpelling = true)]
    [return: NativeTypeName("TSSymbol")]
    public static extern ushort language_symbol_for_name([NativeTypeName("const TSLanguage *")] TSLanguage* self,
        [NativeTypeName("const char *")] sbyte* @string, [NativeTypeName("uint32_t")] uint length,
        [NativeTypeName("bool")] byte is_named);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ts_language_field_count",
        ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint language_field_count([NativeTypeName("const TSLanguage *")] TSLanguage* param0);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl,
        EntryPoint = "ts_language_field_name_for_id", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* language_field_name_for_id([NativeTypeName("const TSLanguage *")] TSLanguage* param0,
        [NativeTypeName("TSFieldId")] ushort param1);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl,
        EntryPoint = "ts_language_field_id_for_name", ExactSpelling = true)]
    [return: NativeTypeName("TSFieldId")]
    public static extern ushort language_field_id_for_name([NativeTypeName("const TSLanguage *")] TSLanguage* param0,
        [NativeTypeName("const char *")] sbyte* param1, [NativeTypeName("uint32_t")] uint param2);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ts_language_symbol_type",
        ExactSpelling = true)]
    public static extern TSSymbolType language_symbol_type([NativeTypeName("const TSLanguage *")] TSLanguage* param0,
        [NativeTypeName("TSSymbol")] ushort param1);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ts_language_version",
        ExactSpelling = true)]
    [return: NativeTypeName("uint32_t")]
    public static extern uint language_version([NativeTypeName("const TSLanguage *")] TSLanguage* param0);

    [DllImport("libtree-sitter", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ts_set_allocator",
        ExactSpelling = true)]
    public static extern void set_allocator(
        [NativeTypeName("void *(*)(size_t)")] delegate* unmanaged[Cdecl]<nuint, void*> new_malloc,
        [NativeTypeName("void *(*)(size_t, size_t)")] delegate* unmanaged[Cdecl]<nuint, nuint, void*> new_calloc,
        [NativeTypeName("void *(*)(void *, size_t)")] delegate* unmanaged[Cdecl]<void*, nuint, void*> new_realloc,
        [NativeTypeName("void (*)(void *)")] delegate* unmanaged[Cdecl]<void*, void> new_free);
}