using System;
using System.Runtime.InteropServices;
using Xunit;

namespace TreeSitter.Bindings.UnitTests;

/// <summary>Provides validation of the <see cref="TSTreeCursor" /> struct.</summary>
public static unsafe partial class TSTreeCursorTests
{
    /// <summary>Validates that the <see cref="TSTreeCursor" /> struct is blittable.</summary>
    [Fact]
    public static void IsBlittableTest()
    {
        Assert.Equal(sizeof(TSTreeCursor), Marshal.SizeOf<TSTreeCursor>());
    }

    /// <summary>Validates that the <see cref="TSTreeCursor" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Fact]
    public static void IsLayoutSequentialTest()
    {
        Assert.True(typeof(TSTreeCursor).IsLayoutSequential);
    }

    /// <summary>Validates that the <see cref="TSTreeCursor" /> struct has the correct size.</summary>
    [Fact]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.Equal(24, sizeof(TSTreeCursor));
        }
        else
        {
            Assert.Equal(16, sizeof(TSTreeCursor));
        }
    }
}
