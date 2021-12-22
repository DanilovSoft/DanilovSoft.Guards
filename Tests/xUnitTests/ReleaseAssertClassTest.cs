#undef DEBUG
using DanilovSoft.Guards.Extensions;
using Xunit;

namespace xUnitTests;

public class ReleaseAssertClassTest
{
    [Fact]
    public void NullString_NoThrow()
    {
        TestMethod(null!);
    }

    [Fact]
    public void NullStringAsNotNull_NoThrow()
    {
        var result = TestMethodReturnValue(null);
        Assert.Null(result);
    }

    private static void TestMethod(string value)
    {
        value.AssertNotNull();
    }

    private static string TestMethodReturnValue(string? value)
    {
        value.AssertNotNull();
        return value;
    }
}
