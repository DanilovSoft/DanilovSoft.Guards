using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace DanilovSoft.Guards.Extensions;

public static class GuardExtensions
{
    /// <summary>Throws exception if <paramref name="value"/> turned out to be <see langword="null"/>.</summary>
    /// <exception cref="ArgumentNullException"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void ThrowIfNull<T>([NotNull] this T value, [CallerArgumentExpression("value")] string? paramName = null) 
        where T : notnull
    {
        if (value is not null)
        {
            return;
        }

        ThrowHelper.ThrowArgumentNull(paramName);
    }

    /// <summary>Throws exception if <paramref name="value"/> turned out to be <see langword="null"/>.</summary>
    /// <exception cref="ArgumentNullException"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T CheckNotNull<T>([NotNull] this T value, [CallerArgumentExpression("value")] string? paramName = null)
        where T : notnull
    {
        if (value is null)
        {
            ThrowHelper.ThrowArgumentNull(paramName);
        }
        return value;
    }

    /// <summary>Throws exception if <paramref name="value"/> turned out to be <see langword="null"/> or empty string.</summary>
    /// <exception cref="ArgumentNullException"/>
    /// <exception cref="ArgumentOutOfRangeException"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void NotNullOrEmpty([NotNull] this string value, string? paramName = null)
    {
        Guard.NotNull(value, paramName);

        if (value.Length != 0)
        {
            return;
        }
        ThrowHelper.ThrowArgumentOutOfRange(value, paramName);
    }
}
