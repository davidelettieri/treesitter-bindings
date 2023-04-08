using System.Runtime.InteropServices;
using Xunit;

namespace TreeSitter.Bindings.UnitTests;

/// <summary>Provides validation of the <see cref="TSParseActionEntry" /> struct.</summary>
public static unsafe partial class TSParseActionEntryTests
{
    /// <summary>Validates that the <see cref="TSParseActionEntry" /> struct is blittable.</summary>
    [Fact]
    public static void IsBlittableTest()
    {
        Assert.Equal(sizeof(TSParseActionEntry), Marshal.SizeOf<TSParseActionEntry>());
    }

    /// <summary>Validates that the <see cref="TSParseActionEntry" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Fact]
    public static void IsLayoutExplicitTest()
    {
        Assert.True(typeof(TSParseActionEntry).IsExplicitLayout);
    }

    /// <summary>Validates that the <see cref="TSParseActionEntry" /> struct has the correct size.</summary>
    [Fact]
    public static void SizeOfTest()
    {
        Assert.Equal(8, sizeof(TSParseActionEntry));
    }
}
