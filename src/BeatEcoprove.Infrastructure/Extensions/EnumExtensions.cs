namespace BeatEcoprove.Infrastructure.Extensions;

public static class EnumExtensions
{
    public static bool CanConvertToEnum<T>(this string value, out T enumValue) where T : struct, Enum
    {
        return Enum.TryParse(value, ignoreCase: true, out enumValue);
    }
}