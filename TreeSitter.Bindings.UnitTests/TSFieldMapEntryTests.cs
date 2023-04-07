using System.Runtime.InteropServices;

namespace TreeSitter.Bindings.UnitTests;

/// <summary>Provides validation of the <see cref="TSFieldMapEntry" /> struct.</summary>
public static unsafe partial class TSFieldMapEntryTests
{
    /// <summary>Validates that the <see cref="TSFieldMapEntry" /> struct is blittable.</summary>
    [Fact]
    public static void IsBlittableTest()
    {
        Assert.Equal(sizeof(TSFieldMapEntry), Marshal.SizeOf<TSFieldMapEntry>());
    }

    /// <summary>Validates that the <see cref="TSFieldMapEntry" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Fact]
    public static void IsLayoutSequentialTest()
    {
        Assert.True(typeof(TSFieldMapEntry).IsLayoutSequential);
    }

    /// <summary>Validates that the <see cref="TSFieldMapEntry" /> struct has the correct size.</summary>
    [Fact]
    public static void SizeOfTest()
    {
        Assert.Equal(4, sizeof(TSFieldMapEntry));
    }
}
