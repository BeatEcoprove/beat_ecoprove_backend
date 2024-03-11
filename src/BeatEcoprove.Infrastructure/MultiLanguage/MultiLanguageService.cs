using System.Globalization;

using BeatEcoprove.Application.Shared.Multilanguage;
using BeatEcoprove.Infrastructure.MultiLanguage.Resources;

using Microsoft.Extensions.Localization;

namespace BeatEcoprove.Infrastructure.MultiLanguage;

public class MultiLanguageService : ILanguageCulture
{
    private readonly IStringLocalizer _localizer;

    public MultiLanguageService(IStringLocalizerFactory factory)
    {
        _localizer = factory.Create(typeof(LanguageResources));
    }

    public string GetChunk(string key, string fallback = "")
    {
        var value = _localizer[key];
        return value == key ? fallback : value;
    }

    public Language GetCurrentCulture()
    {
        CultureInfo? defaultThreadCurrentCulture = CultureInfo.DefaultThreadCurrentCulture;

        if (defaultThreadCurrentCulture is null)
        {
            return Language.Default;
        }

        return Language.FromValue(defaultThreadCurrentCulture.Name) ?? Language.Default;
    }

    public void SetLanguage(Language language)
    {
        CultureInfo.DefaultThreadCurrentCulture = new CultureInfo(language.Value);
    }
}