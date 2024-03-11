using BeatEcoprove.Infrastructure.Authentication;
using BeatEcoprove.Infrastructure.BackgroundJobs;
using BeatEcoprove.Infrastructure.EmailSender;
using BeatEcoprove.Infrastructure.FileStorage;
using BeatEcoprove.Infrastructure.MultiLanguage;
using BeatEcoprove.Infrastructure.Persistence;
using BeatEcoprove.Infrastructure.Providers;
using BeatEcoprove.Infrastructure.Services;
using BeatEcoprove.Infrastructure.WebSockets;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BeatEcoprove.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.SetUpMongoDb();
        services.SetUpRedis();
        services.AddWebSocketImpl();
        services.SetUpBackgroundJobs();
        services.AddEmailSender();
        services.AddBeatAuth();
        services.AddFileStorageConfiguration();
        services.AddProviders();
        services.AddServices();
        services.AddPersistenceLayer();
        services.AddMultiLanguage();

        return services;
    }
}