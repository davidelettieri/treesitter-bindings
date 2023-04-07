using System;
using System.Runtime.InteropServices;
using Xunit;

namespace TreeSitter.Bindings.UnitTests;

/// <summary>Provides validation of the <see cref="TSNode" /> struct.</summary>
public static unsafe partial class TSNodeTests
{
    /// <summary>Validates that the <see cref="TSNode" /> struct is blittable.</summary>
    [Fact]
    public static void IsBlittableTest()
    {
        Assert.Equal(sizeof(TSNode), Marshal.SizeOf<TSNode>());
    }

    /// <summary>Validates that the <see cref="TSNode" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Fact]
    public static void IsLayoutSequentialTest()
    {
        Assert.True(typeof(TSNode).IsLayoutSequential);
    }

    /// <summary>Validates that the <see cref="TSNode" /> struct has the correct size.</summary>
    [Fact]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.Equal(32, sizeof(TSNode));
        }
        else
        {
            Assert.Equal(24, sizeof(TSNode));
        }
    }
}
