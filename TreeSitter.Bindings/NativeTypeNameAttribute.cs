using System.Diagnostics;

namespace TreeSitter.Bindings;

[Conditional("DEBUG")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
internal sealed class NativeTypeNameAttribute : Attribute
{
    public NativeTypeNameAttribute(string name)
    {
        Name = name;
    }

    public string Name { get; }
}