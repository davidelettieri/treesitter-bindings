using System.Runtime.InteropServices;

namespace TreeSitter.Bindings.UnitTests;

/// <summary>Provides validation of the <see cref="TSLexMode" /> struct.</summary>
public static unsafe partial class TSLexModeTests
{
    /// <summary>Validates that the <see cref="TSLexMode" /> struct is blittable.</summary>
    [Fact]
    public static void IsBlittableTest()
    {
        Assert.Equal(sizeof(TSLexMode), Marshal.SizeOf<TSLexMode>());
    }

    /// <summary>Validates that the <see cref="TSLexMode" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Fact]
    public static void IsLayoutSequentialTest()
    {
        Assert.True(typeof(TSLexMode).IsLayoutSequential);
    }

    /// <summary>Validates that the <see cref="TSLexMode" /> struct has the correct size.</summary>
    [Fact]
    public static void SizeOfTest()
    {
        Assert.Equal(4, sizeof(TSLexMode));
    }
}
