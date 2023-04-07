using System.Runtime.InteropServices;
using Xunit;

namespace TreeSitter.Bindings.UnitTests;

/// <summary>Provides validation of the <see cref="TSInputEdit" /> struct.</summary>
public static unsafe partial class TSInputEditTests
{
    /// <summary>Validates that the <see cref="TSInputEdit" /> struct is blittable.</summary>
    [Fact]
    public static void IsBlittableTest()
    {
        Assert.Equal(sizeof(TSInputEdit), Marshal.SizeOf<TSInputEdit>());
    }

    /// <summary>Validates that the <see cref="TSInputEdit" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Fact]
    public static void IsLayoutSequentialTest()
    {
        Assert.True(typeof(TSInputEdit).IsLayoutSequential);
    }

    /// <summary>Validates that the <see cref="TSInputEdit" /> struct has the correct size.</summary>
    [Fact]
    public static void SizeOfTest()
    {
        Assert.Equal(36, sizeof(TSInputEdit));
    }
}
