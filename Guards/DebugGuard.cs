#define DEBUG

using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace DanilovSoft.Guards;

public static class DebugGuard
{
    [Conditional("DEBUG")]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void NotNull([NotNull] object? value, [CallerArgumentExpression("value")] string? paramName = null)
    {
        Debug.Assert(value is not null, $"Value cannot be null. (Parameter '{paramName}')");
    }
}
