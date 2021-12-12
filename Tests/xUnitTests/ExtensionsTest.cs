using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DanilovSoft.Guards;
using DanilovSoft.Guards.Extensions;
using Xunit;

namespace xUnitTests;

public class ExtensionsTest
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

    private static void MethodWithArgument(string testArg)
    {
        testArg.NotNull();
    }
}
