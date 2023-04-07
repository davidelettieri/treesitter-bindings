using System.Runtime.InteropServices;
using Xunit;

namespace TreeSitter.Bindings.UnitTests;

/// <summary>Provides validation of the <see cref="TSParseAction" /> struct.</summary>
public static unsafe partial class TSParseActionTests
{
    /// <summary>Validates that the <see cref="TSParseAction" /> struct is blittable.</summary>
    [Fact]
    public static void IsBlittableTest()
    {
        Assert.Equal(sizeof(TSParseAction), Marshal.SizeOf<TSParseAction>());
    }

    /// <summary>Validates that the <see cref="TSParseAction" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Fact]
    public static void IsLayoutExplicitTest()
    {
        Assert.True(typeof(TSParseAction).IsExplicitLayout);
    }

    /// <summary>Validates that the <see cref="TSParseAction" /> struct has the correct size.</summary>
    [Fact]
    public static void SizeOfTest()
    {
        Assert.Equal(8, sizeof(TSParseAction));
    }
}
