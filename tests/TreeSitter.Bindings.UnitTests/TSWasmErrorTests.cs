using System;
using System.Runtime.InteropServices;
using Xunit;

namespace TreeSitter.Bindings.UnitTests;

/// <summary>Provides validation of the <see cref="TSWasmError" /> struct.</summary>
public static unsafe partial class TSWasmErrorTests
{
    /// <summary>Validates that the <see cref="TSWasmError" /> struct is blittable.</summary>
    [Fact]
    public static void IsBlittableTest()
    {
        Assert.Equal(sizeof(TSWasmError), Marshal.SizeOf<TSWasmError>());
    }

    /// <summary>Validates that the <see cref="TSWasmError" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Fact]
    public static void IsLayoutSequentialTest()
    {
        Assert.True(typeof(TSWasmError).IsLayoutSequential);
    }

    /// <summary>Validates that the <see cref="TSWasmError" /> struct has the correct size.</summary>
    [Fact]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.Equal(16, sizeof(TSWasmError));
        }
        else
        {
            Assert.Equal(8, sizeof(TSWasmError));
        }
    }
}
