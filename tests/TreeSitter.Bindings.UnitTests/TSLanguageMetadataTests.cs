using System.Runtime.InteropServices;
using Xunit;

namespace TreeSitter.Bindings.UnitTests;

/// <summary>Provides validation of the <see cref="TSLanguageMetadata" /> struct.</summary>
public static unsafe partial class TSLanguageMetadataTests
{
    /// <summary>Validates that the <see cref="TSLanguageMetadata" /> struct is blittable.</summary>
    [Fact]
    public static void IsBlittableTest()
    {
        Assert.Equal(sizeof(TSLanguageMetadata), Marshal.SizeOf<TSLanguageMetadata>());
    }

    /// <summary>Validates that the <see cref="TSLanguageMetadata" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Fact]
    public static void IsLayoutSequentialTest()
    {
        Assert.True(typeof(TSLanguageMetadata).IsLayoutSequential);
    }

    /// <summary>Validates that the <see cref="TSLanguageMetadata" /> struct has the correct size.</summary>
    [Fact]
    public static void SizeOfTest()
    {
        Assert.Equal(3, sizeof(TSLanguageMetadata));
    }
}
