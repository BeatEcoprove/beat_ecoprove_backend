using BeatEcoprove.Api.Mappers;
using BeatEcoprove.Api.Middlewares;

namespace BeatEcoprove.Api;

public static class DependencyInjection
{
    private static IServiceCollection AddMiddlewares(this IServiceCollection services)
    {
        services.AddTransient<ProfileCheckerMiddleware>();
        services.AddTransient<WebSocketsMiddleware>();
        
        return services;
    }
    
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        services.AddMiddlewares();
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        services.AddMappings();
        
        services.AddCors();

        return services;
    }
}