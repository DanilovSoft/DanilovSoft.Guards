using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace DanilovSoft.Guards;

public static class Guard
{
    /// <exception cref="ArgumentNullException"/>
    [DebuggerStepThrough]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void NotNull<T>([NotNull] T value, [CallerArgumentExpression("value")] string? paramName = null) 
        where T : notnull
    {
        if (value is not null)
        {
            return;
        }
        ThrowHelper.ThrowArgumentNull(paramName);
    }

    /// <exception cref="ArgumentNullException"/>
    [DebuggerStepThrough]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T AsNotNull<T>([NotNull] T value, [CallerArgumentExpression("value")] string? paramName = null) 
        where T : notnull
    {
        if (value is not null)
        {
            return value;
        }
        ThrowHelper.ThrowArgumentNull(paramName);
        return value;
    }

    /// <exception cref="ArgumentOutOfRangeException"/>
    [DebuggerStepThrough]
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
