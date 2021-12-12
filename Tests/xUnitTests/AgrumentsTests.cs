using System;
using DanilovSoft.Guards;
using Xunit;

namespace xUnitTests;

public class AgrumentsTests
{
    [Fact]
    public void NullArgument_ThrowsNull()
    {
        try
        {
            MethodWithArgument(null!);
            Assert.True(false);
        }
        catch (ArgumentNullException ex)
        {
            Assert.Equal("testArg", ex.ParamName);
        }
    }

    [Fact]
    public void NotNullArgument_NoThrow()
    {
        MethodWithArgument("qwerty");
    }

    private static void MethodWithArgument(string testArg)
    {
        Guard.NotNull(testArg);
    }
}