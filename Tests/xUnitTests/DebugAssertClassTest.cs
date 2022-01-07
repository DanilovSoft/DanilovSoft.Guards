#define DEBUG

using System;
using DanilovSoft.Guards;
using Xunit;

namespace xUnitTests;

public class DebugAssertClassTest
{
    [Fact]
    public void NullString_Throws()
    {
        try
        {
            TestMethod(null!);
            Assert.True(false);
        }
        catch (Exception ex) when (ex.GetType().Name == "DebugAssertException")
        {
        }
    }

    [Fact]
    public void NullStringAsNotNull_Throws()
    {
        try
        {
            TestMethodReturnValue(null);
            Assert.True(false);
        }
        catch (Exception ex) when (ex.GetType().Name == "DebugAssertException")
        {
        }
    }

    private static void TestMethod(string value)
    {
        DebugGuard.NotNull(value);
    }

    private static string TestMethodReturnValue(string? value)
    {
        DebugGuard.NotNull(value);
        return value;
    }
}
