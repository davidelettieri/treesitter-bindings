using System.Runtime.InteropServices;

namespace TreeSitter.Bindings.UnitTests;

/// <summary>Provides validation of the <see cref="TSLexer" /> struct.</summary>
public static unsafe partial class TSLexerTests
{
    /// <summary>Validates that the <see cref="TSLexer" /> struct is blittable.</summary>
    [Fact]
    public static void IsBlittableTest()
    {
        Assert.Equal(sizeof(TSLexer), Marshal.SizeOf<TSLexer>());
    }

    /// <summary>Validates that the <see cref="TSLexer" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Fact]
    public static void IsLayoutSequentialTest()
    {
        Assert.True(typeof(TSLexer).IsLayoutSequential);
    }

    /// <summary>Validates that the <see cref="TSLexer" /> struct has the correct size.</summary>
    [Fact]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.Equal(48, sizeof(TSLexer));
        }
        else
        {
            Assert.Equal(28, sizeof(TSLexer));
        }
    }
}
