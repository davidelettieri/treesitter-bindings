using System;
using System.Runtime.InteropServices;
using Xunit;

namespace TreeSitter.Bindings.UnitTests;

/// <summary>Provides validation of the <see cref="TSLogger" /> struct.</summary>
public static unsafe partial class TSLoggerTests
{
    /// <summary>Validates that the <see cref="TSLogger" /> struct is blittable.</summary>
    [Fact]
    public static void IsBlittableTest()
    {
        Assert.Equal(sizeof(TSLogger), Marshal.SizeOf<TSLogger>());
    }

    /// <summary>Validates that the <see cref="TSLogger" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Fact]
    public static void IsLayoutSequentialTest()
    {
        Assert.True(typeof(TSLogger).IsLayoutSequential);
    }

    /// <summary>Validates that the <see cref="TSLogger" /> struct has the correct size.</summary>
    [Fact]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.Equal(16, sizeof(TSLogger));
        }
        else
        {
            Assert.Equal(8, sizeof(TSLogger));
        }
    }
}
