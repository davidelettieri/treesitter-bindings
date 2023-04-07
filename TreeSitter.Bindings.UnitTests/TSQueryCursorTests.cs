using System.Runtime.InteropServices;

namespace TreeSitter.Bindings.UnitTests;

/// <summary>Provides validation of the <see cref="TSQueryCursor" /> struct.</summary>
public static unsafe partial class TSQueryCursorTests
{
    /// <summary>Validates that the <see cref="TSQueryCursor" /> struct is blittable.</summary>
    [Fact]
    public static void IsBlittableTest()
    {
        Assert.Equal(sizeof(TSQueryCursor), Marshal.SizeOf<TSQueryCursor>());
    }

    /// <summary>Validates that the <see cref="TSQueryCursor" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Fact]
    public static void IsLayoutSequentialTest()
    {
        Assert.True(typeof(TSQueryCursor).IsLayoutSequential);
    }

    /// <summary>Validates that the <see cref="TSQueryCursor" /> struct has the correct size.</summary>
    [Fact]
    public static void SizeOfTest()
    {
        Assert.Equal(1, sizeof(TSQueryCursor));
    }
}
