using BeatEcoprove.Api.Mappers;

namespace BeatEcoprove.Api;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        services.AddControllers();
        services.AddMappings();

        return services;
    }
}