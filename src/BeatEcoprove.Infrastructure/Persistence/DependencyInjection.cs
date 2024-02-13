using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Persistence;
using BeatEcoprove.Infrastructure.Persistence.Interceptors;
using BeatEcoprove.Infrastructure.Persistence.Repositories;
using BeatEcoprove.Infrastructure.Persistence.Shared;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Configuration;

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

        services.AddScoped<IAuthRepository, AuthRepository>();
        services.AddScoped<IProfileRepository, ProfileRepository>();
        services.AddScoped<IClothRepository, ClothRepository>();
        services.AddScoped<IBucketRepository, BucketRepository>();
        services.AddScoped<IColorRepository, ColorRepository>();
        services.AddScoped<IBrandRepository, BrandRepository>();
        services.AddScoped<IActivityRepository, ActionRepository>();
        services.AddScoped<IGroupRepository, GroupRepository>();
        services.AddScoped<IMaintenanceServiceRepository, MaintenanceServiceRepository>();
        services.AddScoped<IFeedBackRepository, FeedBackRepository>();
        services.AddScoped<INotificationRepository, NotificationRepository>();

        return services;
    }
}
