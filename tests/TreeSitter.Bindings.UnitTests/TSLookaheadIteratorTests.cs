using System.Runtime.InteropServices;
using Xunit;

namespace TreeSitter.Bindings.UnitTests;

/// <summary>Provides validation of the <see cref="TSLookaheadIterator" /> struct.</summary>
public static unsafe partial class TSLookaheadIteratorTests
{
    /// <summary>Validates that the <see cref="TSLookaheadIterator" /> struct is blittable.</summary>
    [Fact]
    public static void IsBlittableTest()
    {
        Assert.Equal(sizeof(TSLookaheadIterator), Marshal.SizeOf<TSLookaheadIterator>());
    }

    /// <summary>Validates that the <see cref="TSLookaheadIterator" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Fact]
    public static void IsLayoutSequentialTest()
    {
        Assert.True(typeof(TSLookaheadIterator).IsLayoutSequential);
    }

    /// <summary>Validates that the <see cref="TSLookaheadIterator" /> struct has the correct size.</summary>
    [Fact]
    public static void SizeOfTest()
    {
        Assert.Equal(1, sizeof(TSLookaheadIterator));
    }
}
