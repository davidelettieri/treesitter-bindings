using System.Runtime.InteropServices;

namespace TreeSitter.Bindings.UnitTests;

/// <summary>Provides validation of the <see cref="TSRange" /> struct.</summary>
public static unsafe partial class TSRangeTests
{
    /// <summary>Validates that the <see cref="TSRange" /> struct is blittable.</summary>
    [Fact]
    public static void IsBlittableTest()
    {
        Assert.Equal(sizeof(TSRange), Marshal.SizeOf<TSRange>());
    }

    /// <summary>Validates that the <see cref="TSRange" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Fact]
    public static void IsLayoutSequentialTest()
    {
        Assert.True(typeof(TSRange).IsLayoutSequential);
    }

    /// <summary>Validates that the <see cref="TSRange" /> struct has the correct size.</summary>
    [Fact]
    public static void SizeOfTest()
    {
        Assert.Equal(24, sizeof(TSRange));
    }
}
