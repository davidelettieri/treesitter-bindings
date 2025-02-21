using System;
using System.Runtime.InteropServices;
using Xunit;

namespace TreeSitter.Bindings.UnitTests;

/// <summary>Provides validation of the <see cref="TSParseState" /> struct.</summary>
public static unsafe partial class TSParseStateTests
{
    /// <summary>Validates that the <see cref="TSParseState" /> struct is blittable.</summary>
    [Fact]
    public static void IsBlittableTest()
    {
        Assert.Equal(sizeof(TSParseState), Marshal.SizeOf<TSParseState>());
    }

    /// <summary>Validates that the <see cref="TSParseState" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Fact]
    public static void IsLayoutSequentialTest()
    {
        Assert.True(typeof(TSParseState).IsLayoutSequential);
    }

    /// <summary>Validates that the <see cref="TSParseState" /> struct has the correct size.</summary>
    [Fact]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.Equal(16, sizeof(TSParseState));
        }
        else
        {
            Assert.Equal(12, sizeof(TSParseState));
        }
    }
}
