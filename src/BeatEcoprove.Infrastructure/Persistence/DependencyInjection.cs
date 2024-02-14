using BeatEcoprove.Application.Shared.Interfaces.Persistence;
using BeatEcoprove.Infrastructure.Persistence.Interceptors;
using BeatEcoprove.Infrastructure.Persistence.Shared;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Configuration;
using Scrutor;

namespace BeatEcoprove.Infrastructure.Persistence;

public static class DependencyInjection
{
    public static IServiceCollection AddPersistenceLayer(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        var dbSettings = new DbSettings();
        configuration.Bind(DbSettings.Section, dbSettings);
        services.AddSingleton(Options.Create(dbSettings));

        services.AddDbContext<BeatEcoproveDbContext>();
        services.AddScoped<IApplicationDbContext>(provider => provider.GetService<BeatEcoproveDbContext>()!);
        services.AddScoped<IUnitOfWork>(provider => provider.GetService<BeatEcoproveDbContext>()!);

        services.AddScoped<SoftDeleteInterceptor>();
        services.AddScoped<PublishDomainEventsInterceptor>();
        services.AddScoped<StoreGroupInterceptor>();

        AddRepositories(services);

        return services;
    }

    private static void AddRepositories(IServiceCollection services)
    {
        services.Scan(selector => selector.FromAssemblies(
            typeof(DependencyInjection).Assembly
            )
            .AddClasses(false)
            .UsingRegistrationStrategy(RegistrationStrategy.Skip)
            .AsMatchingInterface()
            .WithScopedLifetime()
        );
    }
}
