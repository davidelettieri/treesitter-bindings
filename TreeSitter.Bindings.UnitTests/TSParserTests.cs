using System.Runtime.InteropServices;
using Xunit;

namespace TreeSitter.Bindings.UnitTests;

/// <summary>Provides validation of the <see cref="TSParser" /> struct.</summary>
public static unsafe partial class TSParserTests
{
    /// <summary>Validates that the <see cref="TSParser" /> struct is blittable.</summary>
    [Fact]
    public static void IsBlittableTest()
    {
        Assert.Equal(sizeof(TSParser), Marshal.SizeOf<TSParser>());
    }

    /// <summary>Validates that the <see cref="TSParser" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Fact]
    public static void IsLayoutSequentialTest()
    {
        Assert.True(typeof(TSParser).IsLayoutSequential);
    }

    /// <summary>Validates that the <see cref="TSParser" /> struct has the correct size.</summary>
    [Fact]
    public static void SizeOfTest()
    {
        Assert.Equal(1, sizeof(TSParser));
    }
}
