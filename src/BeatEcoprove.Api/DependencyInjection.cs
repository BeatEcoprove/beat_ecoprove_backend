using Asp.Versioning;

using BeatEcoprove.Api.Mappers;
using BeatEcoprove.Api.Middlewares;

using OpenTelemetry.Metrics;
using OpenTelemetry.Trace;

namespace BeatEcoprove.Api;

public static class DependencyInjection
{
    private static IServiceCollection AddTelemetry(this IServiceCollection services)
    {
        services.AddOpenTelemetry()
            .WithMetrics(metrics =>
            {
                metrics.AddRuntimeInstrumentation()
                    .AddProcessInstrumentation()
                    .AddAspNetCoreInstrumentation()
                    .AddHttpClientInstrumentation();

                metrics.AddEventCountersInstrumentation(events =>
                {
                    events.AddEventSources("Microsoft-AspNetCore-Hosting");
                    events.AddEventSources("Microsoft-AspNetCore-Server-Kestrel");
                    events.AddEventSources("System-Net-Http");
                });
                
                metrics.AddPrometheusExporter();
            });

        return services;
    }

    private static IServiceCollection AddApiVersion(this IServiceCollection services)
    {
        services.AddApiVersioning(options =>
        {
            options.DefaultApiVersion = new ApiVersion(1, 0);
            options.AssumeDefaultVersionWhenUnspecified = true;
            options.ApiVersionReader = new UrlSegmentApiVersionReader();
        }).AddApiExplorer(options =>
        {
            options.GroupNameFormat = "'v'VVV";
            options.SubstituteApiVersionInUrl = true;
        });

        return services;
    }

    private static IServiceCollection AddMiddlewares(this IServiceCollection services)
    {
        services.AddTransient<ProfileCheckerMiddleware>();
        services.AddTransient<WebSocketsMiddleware>();

        return services;
    }

    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        services.AddTelemetry();
        services.AddApiVersion();

        services.AddMiddlewares();
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        services.AddMappings();

        services.AddCors();

        return services;
    }
}