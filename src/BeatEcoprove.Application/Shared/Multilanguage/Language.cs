using System.Globalization;

using BeatEcoprove.Domain.Shared.Models;

namespace BeatEcoprove.Application.Shared.Multilanguage;

public class Language : Enumeration<Language, string>
{
    public static readonly Language Portuguese = new("pt-PT", typeof(CultureInfo));
    public static Language Default => Portuguese;

    public Language(string value, Type type)
        : base(value, type)
    {
    }

    public static List<CultureInfo> GetSupportedLanguages()
    {
        return Enumerations
            .Values
            .Select(language => (CultureInfo)language)
            .ToList();
    }

    public static implicit operator CultureInfo(Language language) => new(language.Value);
}