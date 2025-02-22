using System;
using System.Runtime.InteropServices;
using Xunit;

namespace TreeSitter.Bindings.UnitTests;

/// <summary>Provides validation of the <see cref="TSQueryCursorState" /> struct.</summary>
public static unsafe partial class TSQueryCursorStateTests
{
    /// <summary>Validates that the <see cref="TSQueryCursorState" /> struct is blittable.</summary>
    [Fact]
    public static void IsBlittableTest()
    {
        Assert.Equal(sizeof(TSQueryCursorState), Marshal.SizeOf<TSQueryCursorState>());
    }

    /// <summary>Validates that the <see cref="TSQueryCursorState" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Fact]
    public static void IsLayoutSequentialTest()
    {
        Assert.True(typeof(TSQueryCursorState).IsLayoutSequential);
    }

    /// <summary>Validates that the <see cref="TSQueryCursorState" /> struct has the correct size.</summary>
    [Fact]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.Equal(16, sizeof(TSQueryCursorState));
        }
        else
        {
            Assert.Equal(8, sizeof(TSQueryCursorState));
        }
    }
}
