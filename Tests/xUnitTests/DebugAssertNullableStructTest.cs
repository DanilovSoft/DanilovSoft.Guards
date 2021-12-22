#define DEBUG
using System;
using DanilovSoft.Guards.Extensions;
using Xunit;

namespace xUnitTests;

public class DebugAssertNullableStructTest
{
    [Fact]
    public void NullStruct_Throws()
    {
        try
        {
            TestMethod(new int?());
            Assert.True(false);
        }
        catch (Exception ex) when (ex.GetType().Name == "DebugAssertException")
        {
        }
    }

    [Fact]
    public void NullStructAsNotNull_Pass()
    {
        var result = TestMethodAsNotNull(123);
        Assert.Equal(123, result);
    }

    private static void TestMethod(int? value)
    {
        value.AssertNotNull();
    }

    private static int TestMethodAsNotNull(int? value)
    {
        value.AssertNotNull();
        return value.Value;
    }
}
