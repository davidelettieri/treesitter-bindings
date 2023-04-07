using System.Runtime.InteropServices;

namespace TreeSitter.Bindings.UnitTests;

/// <summary>Provides validation of the <see cref="TSQueryPredicateStep" /> struct.</summary>
public static unsafe partial class TSQueryPredicateStepTests
{
    /// <summary>Validates that the <see cref="TSQueryPredicateStep" /> struct is blittable.</summary>
    [Fact]
    public static void IsBlittableTest()
    {
        Assert.Equal(sizeof(TSQueryPredicateStep), Marshal.SizeOf<TSQueryPredicateStep>());
    }

    /// <summary>Validates that the <see cref="TSQueryPredicateStep" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Fact]
    public static void IsLayoutSequentialTest()
    {
        Assert.True(typeof(TSQueryPredicateStep).IsLayoutSequential);
    }

    /// <summary>Validates that the <see cref="TSQueryPredicateStep" /> struct has the correct size.</summary>
    [Fact]
    public static void SizeOfTest()
    {
        Assert.Equal(8, sizeof(TSQueryPredicateStep));
    }
}
