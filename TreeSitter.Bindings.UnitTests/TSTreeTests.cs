using System.Runtime.InteropServices;

namespace TreeSitter.Bindings.UnitTests;

/// <summary>Provides validation of the <see cref="TSTree" /> struct.</summary>
public static unsafe partial class TSTreeTests
{
    /// <summary>Validates that the <see cref="TSTree" /> struct is blittable.</summary>
    [Fact]
    public static void IsBlittableTest()
    {
        Assert.Equal(sizeof(TSTree), Marshal.SizeOf<TSTree>());
    }

    /// <summary>Validates that the <see cref="TSTree" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Fact]
    public static void IsLayoutSequentialTest()
    {
        Assert.True(typeof(TSTree).IsLayoutSequential);
    }

    /// <summary>Validates that the <see cref="TSTree" /> struct has the correct size.</summary>
    [Fact]
    public static void SizeOfTest()
    {
        Assert.Equal(1, sizeof(TSTree));
    }
}
