using System.Runtime.InteropServices;
using Xunit;

namespace TreeSitter.Bindings.UnitTests;

/// <summary>Provides validation of the <see cref="TSPoint" /> struct.</summary>
public static unsafe partial class TSPointTests
{
    /// <summary>Validates that the <see cref="TSPoint" /> struct is blittable.</summary>
    [Fact]
    public static void IsBlittableTest()
    {
        Assert.Equal(sizeof(TSPoint), Marshal.SizeOf<TSPoint>());
    }

    /// <summary>Validates that the <see cref="TSPoint" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Fact]
    public static void IsLayoutSequentialTest()
    {
        Assert.True(typeof(TSPoint).IsLayoutSequential);
    }

    /// <summary>Validates that the <see cref="TSPoint" /> struct has the correct size.</summary>
    [Fact]
    public static void SizeOfTest()
    {
        Assert.Equal(8, sizeof(TSPoint));
    }
}
