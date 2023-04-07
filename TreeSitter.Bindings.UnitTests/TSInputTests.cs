using System.Runtime.InteropServices;

namespace TreeSitter.Bindings.UnitTests;

/// <summary>Provides validation of the <see cref="TSInput" /> struct.</summary>
public static unsafe partial class TSInputTests
{
    /// <summary>Validates that the <see cref="TSInput" /> struct is blittable.</summary>
    [Fact]
    public static void IsBlittableTest()
    {
        Assert.Equal(sizeof(TSInput), Marshal.SizeOf<TSInput>());
    }

    /// <summary>Validates that the <see cref="TSInput" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Fact]
    public static void IsLayoutSequentialTest()
    {
        Assert.True(typeof(TSInput).IsLayoutSequential);
    }

    /// <summary>Validates that the <see cref="TSInput" /> struct has the correct size.</summary>
    [Fact]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.Equal(24, sizeof(TSInput));
        }
        else
        {
            Assert.Equal(12, sizeof(TSInput));
        }
    }
}
