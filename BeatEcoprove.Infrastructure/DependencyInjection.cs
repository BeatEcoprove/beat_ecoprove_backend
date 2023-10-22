using BeatEcoprove.Application.Interfaces.Persistence;
using BeatEcoprove.Application.Interfaces.Persistence.Repositories;
using BeatEcoprove.Infrastructure.Persistence;
using BeatEcoprove.Infrastructure.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace BeatEcoprove.Infrastructure;

public static class DependencyInjection
{
    private static IServiceCollection AddPersistence(this IServiceCollection services)
    {
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<IUserRepository, UserRepository>();
        
        return services;
    }
    
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddPersistence();
        
        return services;
    }
}