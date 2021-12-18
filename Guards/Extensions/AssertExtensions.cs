using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace DanilovSoft.Guards.Extensions;

public static class AssertExtensions
{
    [Conditional("DEBUG")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void AssertNotNull<T>([NotNull] this T value, [CallerArgumentExpression("value")] string? paramName = null)
        where T : notnull
    {
        DebugGuard.NotNull(value, paramName);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T AssertCheckNotNull<T>([NotNull] this T value, [CallerArgumentExpression("value")] string? paramName = null)
        where T : notnull
    {
        DebugGuard.NotNull(value, paramName);
        return value;
    }
}
