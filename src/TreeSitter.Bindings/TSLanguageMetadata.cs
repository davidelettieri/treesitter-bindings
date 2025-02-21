namespace TreeSitter.Bindings;

public partial struct TSLanguageMetadata
{
    [NativeTypeName("uint8_t")]
    public byte major_version;

    [NativeTypeName("uint8_t")]
    public byte minor_version;

    [NativeTypeName("uint8_t")]
    public byte patch_version;
}
