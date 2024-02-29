using Microsoft.Extensions.DependencyInjection;

namespace BeatEcoprove.Infrastructure.BackgroundJobs;

public static class DependencyInjection
{
    public static IServiceCollection SetUpBackgroundJobs(this IServiceCollection services)
    {
        services.AddHostedService<PgNotificationListener>();

        return services;
    }
}