using System.Runtime.InteropServices;

namespace TreeSitter.Bindings.UnitTests;

/// <summary>Provides validation of the <see cref="TSQueryCapture" /> struct.</summary>
public static unsafe partial class TSQueryCaptureTests
{
    /// <summary>Validates that the <see cref="TSQueryCapture" /> struct is blittable.</summary>
    [Fact]
    public static void IsBlittableTest()
    {
        Assert.Equal(sizeof(TSQueryCapture), Marshal.SizeOf<TSQueryCapture>());
    }

    /// <summary>Validates that the <see cref="TSQueryCapture" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Fact]
    public static void IsLayoutSequentialTest()
    {
        Assert.True(typeof(TSQueryCapture).IsLayoutSequential);
    }

    /// <summary>Validates that the <see cref="TSQueryCapture" /> struct has the correct size.</summary>
    [Fact]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.Equal(40, sizeof(TSQueryCapture));
        }
        else
        {
            Assert.Equal(28, sizeof(TSQueryCapture));
        }
    }
}
