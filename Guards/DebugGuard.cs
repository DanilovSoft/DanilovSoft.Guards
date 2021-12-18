using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace DanilovSoft.Guards;

public static class DebugGuard
{
    [Conditional("DEBUG")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void NotNull<T>([NotNull] T value, [CallerArgumentExpression("value")] string? paramName = null)
        where T : notnull
    {
        Debug.Assert(value is not null, $"Value cannot be null. (Parameter '{paramName}')");
    }
}
