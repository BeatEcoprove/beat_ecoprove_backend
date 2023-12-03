namespace BeatEcoprove.Application.Shared.Extensions;

public static class StringExtensions
{
    public static string Capitalize(this string value)
    {
        var words = value.Split(' ');

        for (var i = 0; i < words.Length; i++)
        {
            if (!string.IsNullOrEmpty(words[i]))
            {
                words[i] = char.ToUpper(words[i][0]) + words[i][1..];
            }
        }

        return string.Join(" ", words);
    }
}