using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace DanilovSoft.Guards;

public static class Guard
{
    /// <exception cref="ArgumentNullException"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void ThrowIfNull<T>([NotNull] T value, [CallerArgumentExpression("value")] string? paramName = null) 
    {
        if (value is not null)
        {
            return;
        }
        ThrowHelper.ThrowArgumentNull(paramName);
    }

    /// <exception cref="ArgumentNullException"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T NotNull<T>([NotNull] T value, [CallerArgumentExpression("value")] string? paramName = null)
    {
        if (value is not null)
        {
            return value;
        }
        return ThrowHelper.ThrowArgumentNullReturn<T>(paramName);
    }

    /// <exception cref="ArgumentOutOfRangeException"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void NotDefault<T>(T value, [CallerArgumentExpression("value")] string? paramName = null)
    {
        if (!EqualityComparer<T>.Default.Equals(value, default))
        {
            return;
        }

        ThrowHelper.ThrowArgumentOutOfRange(value, paramName);
    }
}
