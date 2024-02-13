using BeatEcoprove.Application.Shared.Interfaces.Providers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Protocols;

namespace BeatEcoprove.Infrastructure.FileStorage;

public static class DependencyInjection
{
    private const string BaseDirectory = "public";

    public static IServiceCollection AddFileStorageConfiguration(
        this IServiceCollection services)
    {
        var mailSenderSettings = new LocalFileStorageSettings
        {
            FolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, BaseDirectory),
            PublicFolder = BaseDirectory
        };

        services.AddSingleton(Options.Create(mailSenderSettings));
        services.AddScoped<IFileStorageProvider, LocalFileStorageProvider>();

        return services;
    }
}
