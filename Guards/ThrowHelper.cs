using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace DanilovSoft.Guards;

internal static class ThrowHelper
{
    /// <exception cref="ArgumentOutOfRangeException"/>
    [DoesNotReturn]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ThrowArgumentOutOfRange<T>(T value, string? paramName)
    {
        throw new ArgumentOutOfRangeException(paramName, value, null);
    }

    /// <exception cref="ArgumentNullException"/>
    [DoesNotReturn]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ThrowArgumentNull(string? paramName)
    {
        throw new ArgumentNullException(paramName);
    }

    /// <exception cref="ArgumentNullException"/>
    [DoesNotReturn]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static T ThrowArgumentNullReturn<T>(string? paramName)
    {
        throw new ArgumentNullException(paramName);
    }
}
