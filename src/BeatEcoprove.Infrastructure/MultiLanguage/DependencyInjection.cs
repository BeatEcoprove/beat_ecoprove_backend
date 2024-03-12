using BeatEcoprove.Application.Shared.Multilanguage;

using Microsoft.Extensions.DependencyInjection;

namespace BeatEcoprove.Infrastructure.MultiLanguage;

public static class DependencyInjection
{
    public static IServiceCollection AddMultiLanguage(this IServiceCollection services)
    {
        services.AddLocalization();
        services.AddSingleton<ILanguageCulture, MultiLanguageService>();
        return services;
    }
}