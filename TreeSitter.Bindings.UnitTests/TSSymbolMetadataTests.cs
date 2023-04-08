using System.Runtime.InteropServices;
using Xunit;

namespace TreeSitter.Bindings.UnitTests;

/// <summary>Provides validation of the <see cref="TSSymbolMetadata" /> struct.</summary>
public static unsafe partial class TSSymbolMetadataTests
{
    /// <summary>Validates that the <see cref="TSSymbolMetadata" /> struct is blittable.</summary>
    [Fact]
    public static void IsBlittableTest()
    {
        Assert.Equal(sizeof(TSSymbolMetadata), Marshal.SizeOf<TSSymbolMetadata>());
    }

    /// <summary>Validates that the <see cref="TSSymbolMetadata" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Fact]
    public static void IsLayoutSequentialTest()
    {
        Assert.True(typeof(TSSymbolMetadata).IsLayoutSequential);
    }

    /// <summary>Validates that the <see cref="TSSymbolMetadata" /> struct has the correct size.</summary>
    [Fact]
    public static void SizeOfTest()
    {
        Assert.Equal(3, sizeof(TSSymbolMetadata));
    }
}
