using System.Runtime.InteropServices;
using Xunit;

namespace TreeSitter.Bindings.UnitTests;

/// <summary>Provides validation of the <see cref="TSQuery" /> struct.</summary>
public static unsafe partial class TSQueryTests
{
    /// <summary>Validates that the <see cref="TSQuery" /> struct is blittable.</summary>
    [Fact]
    public static void IsBlittableTest()
    {
        Assert.Equal(sizeof(TSQuery), Marshal.SizeOf<TSQuery>());
    }

    /// <summary>Validates that the <see cref="TSQuery" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Fact]
    public static void IsLayoutSequentialTest()
    {
        Assert.True(typeof(TSQuery).IsLayoutSequential);
    }

    /// <summary>Validates that the <see cref="TSQuery" /> struct has the correct size.</summary>
    [Fact]
    public static void SizeOfTest()
    {
        Assert.Equal(1, sizeof(TSQuery));
    }
}
