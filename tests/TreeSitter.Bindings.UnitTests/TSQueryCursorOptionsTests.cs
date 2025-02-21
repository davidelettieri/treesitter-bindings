using System;
using System.Runtime.InteropServices;
using Xunit;

namespace TreeSitter.Bindings.UnitTests;

/// <summary>Provides validation of the <see cref="TSQueryCursorOptions" /> struct.</summary>
public static unsafe partial class TSQueryCursorOptionsTests
{
    /// <summary>Validates that the <see cref="TSQueryCursorOptions" /> struct is blittable.</summary>
    [Fact]
    public static void IsBlittableTest()
    {
        Assert.Equal(sizeof(TSQueryCursorOptions), Marshal.SizeOf<TSQueryCursorOptions>());
    }

    /// <summary>Validates that the <see cref="TSQueryCursorOptions" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Fact]
    public static void IsLayoutSequentialTest()
    {
        Assert.True(typeof(TSQueryCursorOptions).IsLayoutSequential);
    }

    /// <summary>Validates that the <see cref="TSQueryCursorOptions" /> struct has the correct size.</summary>
    [Fact]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.Equal(16, sizeof(TSQueryCursorOptions));
        }
        else
        {
            Assert.Equal(8, sizeof(TSQueryCursorOptions));
        }
    }
}
