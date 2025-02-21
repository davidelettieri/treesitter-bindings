namespace TreeSitter.Bindings;

[NativeTypeName("unsigned int")]
public enum TSInputEncoding : uint
{
    TSInputEncodingUTF8,
    TSInputEncodingUTF16LE,
    TSInputEncodingUTF16BE,
    TSInputEncodingCustom,
}
