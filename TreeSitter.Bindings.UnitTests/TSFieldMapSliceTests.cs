using System.Runtime.InteropServices;

namespace TreeSitter.Bindings.UnitTests;

/// <summary>Provides validation of the <see cref="TSFieldMapSlice" /> struct.</summary>
public static unsafe partial class TSFieldMapSliceTests
{
    /// <summary>Validates that the <see cref="TSFieldMapSlice" /> struct is blittable.</summary>
    [Fact]
    public static void IsBlittableTest()
    {
        Assert.Equal(sizeof(TSFieldMapSlice), Marshal.SizeOf<TSFieldMapSlice>());
    }

    /// <summary>Validates that the <see cref="TSFieldMapSlice" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Fact]
    public static void IsLayoutSequentialTest()
    {
        Assert.True(typeof(TSFieldMapSlice).IsLayoutSequential);
    }

    /// <summary>Validates that the <see cref="TSFieldMapSlice" /> struct has the correct size.</summary>
    [Fact]
    public static void SizeOfTest()
    {
        Assert.Equal(4, sizeof(TSFieldMapSlice));
    }
}
