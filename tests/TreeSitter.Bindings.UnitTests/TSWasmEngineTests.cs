using System.Runtime.InteropServices;
using Xunit;

namespace TreeSitter.Bindings.UnitTests;

/// <summary>Provides validation of the <see cref="TSWasmEngine" /> struct.</summary>
public static unsafe partial class TSWasmEngineTests
{
    /// <summary>Validates that the <see cref="TSWasmEngine" /> struct is blittable.</summary>
    [Fact]
    public static void IsBlittableTest()
    {
        Assert.Equal(sizeof(TSWasmEngine), Marshal.SizeOf<TSWasmEngine>());
    }

    /// <summary>Validates that the <see cref="TSWasmEngine" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Fact]
    public static void IsLayoutSequentialTest()
    {
        Assert.True(typeof(TSWasmEngine).IsLayoutSequential);
    }

    /// <summary>Validates that the <see cref="TSWasmEngine" /> struct has the correct size.</summary>
    [Fact]
    public static void SizeOfTest()
    {
        Assert.Equal(1, sizeof(TSWasmEngine));
    }
}
