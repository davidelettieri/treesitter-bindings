using System.Runtime.InteropServices;

namespace TreeSitter.Bindings.UnitTests;

/// <summary>Provides validation of the <see cref="TSQueryMatch" /> struct.</summary>
public static unsafe partial class TSQueryMatchTests
{
    /// <summary>Validates that the <see cref="TSQueryMatch" /> struct is blittable.</summary>
    [Fact]
    public static void IsBlittableTest()
    {
        Assert.Equal(sizeof(TSQueryMatch), Marshal.SizeOf<TSQueryMatch>());
    }

    /// <summary>Validates that the <see cref="TSQueryMatch" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Fact]
    public static void IsLayoutSequentialTest()
    {
        Assert.True(typeof(TSQueryMatch).IsLayoutSequential);
    }

    /// <summary>Validates that the <see cref="TSQueryMatch" /> struct has the correct size.</summary>
    [Fact]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.Equal(16, sizeof(TSQueryMatch));
        }
        else
        {
            Assert.Equal(12, sizeof(TSQueryMatch));
        }
    }
}
