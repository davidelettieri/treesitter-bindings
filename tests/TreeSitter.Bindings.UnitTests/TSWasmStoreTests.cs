using System.Runtime.InteropServices;
using Xunit;

namespace TreeSitter.Bindings.UnitTests;

/// <summary>Provides validation of the <see cref="TSWasmStore" /> struct.</summary>
public static unsafe partial class TSWasmStoreTests
{
    /// <summary>Validates that the <see cref="TSWasmStore" /> struct is blittable.</summary>
    [Fact]
    public static void IsBlittableTest()
    {
        Assert.Equal(sizeof(TSWasmStore), Marshal.SizeOf<TSWasmStore>());
    }

    /// <summary>Validates that the <see cref="TSWasmStore" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Fact]
    public static void IsLayoutSequentialTest()
    {
        Assert.True(typeof(TSWasmStore).IsLayoutSequential);
    }

    /// <summary>Validates that the <see cref="TSWasmStore" /> struct has the correct size.</summary>
    [Fact]
    public static void SizeOfTest()
    {
        Assert.Equal(1, sizeof(TSWasmStore));
    }
}
