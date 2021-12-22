using DanilovSoft.Guards.Extensions;

namespace Guard.DebugApp;

public static class Program
{
    static void Main()
    {
        TestMethod(null);
    }

    public static void TestMethod(string? arg)
    {
        arg.AssertNotNull();

        _ = arg.Length;
    }
}