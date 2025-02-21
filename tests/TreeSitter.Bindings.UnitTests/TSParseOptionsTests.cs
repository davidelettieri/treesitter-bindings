using System;
using System.Runtime.InteropServices;
using Xunit;

namespace TreeSitter.Bindings.UnitTests;

/// <summary>Provides validation of the <see cref="TSParseOptions" /> struct.</summary>
public static unsafe partial class TSParseOptionsTests
{
    /// <summary>Validates that the <see cref="TSParseOptions" /> struct is blittable.</summary>
    [Fact]
    public static void IsBlittableTest()
    {
        Assert.Equal(sizeof(TSParseOptions), Marshal.SizeOf<TSParseOptions>());
    }

    /// <summary>Validates that the <see cref="TSParseOptions" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Fact]
    public static void IsLayoutSequentialTest()
    {
        Assert.True(typeof(TSParseOptions).IsLayoutSequential);
    }

    /// <summary>Validates that the <see cref="TSParseOptions" /> struct has the correct size.</summary>
    [Fact]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.Equal(16, sizeof(TSParseOptions));
        }
        else
        {
            Assert.Equal(8, sizeof(TSParseOptions));
        }
    }
}
