using BeatEcoprove.Infrastructure.Shared;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Bson.Serialization;
using Scrutor;

namespace BeatEcoprove.Infrastructure.Persistence.Configurations;

public static class ConfigurationExtensions
{
    public static IServiceCollection RegisterDocumentConfigurations(
        this IServiceCollection services,
        Type? type = null)
    {
        var configurationAssembly = type?.Assembly ?? typeof(ConfigurationExtensions).Assembly;
        var methodName = nameof(IDocumentTypeConfiguration<dynamic>.Configure) ?? "";

        var configurations = configurationAssembly.GetTypes()
            .Where(type => type.GetInterfaces()
                .Any(i => IsDocumentConfiguration(i)))
            .ToList();

        services.Scan(selector => selector
            .FromAssemblies(configurationAssembly)
            .AddClasses(classes => classes.AssignableTo(typeof(IDocumentTypeConfiguration<>)))
            .UsingRegistrationStrategy(RegistrationStrategy.Skip)
            .AsSelf()
            .WithScopedLifetime()
        );

        var serviceProvider = services.BuildServiceProvider();

        foreach (var configuration in configurations)
        {
            var genericType = configuration.GetInterfaces()[0].GetGenericArguments()[0];
            var configurationService = serviceProvider.GetService(configuration);

            if (configurationService is null)
            {
                continue;
            }

            var bsonClassMapType = typeof(BsonClassMap<>).MakeGenericType(genericType);
            var configurationMethod = configurationService.GetType().GetMethod(methodName);

            if (bsonClassMapType is null || configurationMethod is null)
            {
                continue;
            }

            var bsonClassMap = Activator.CreateInstance(bsonClassMapType);
            configurationMethod.Invoke(configurationService, new[] { bsonClassMap });
            BsonClassMap.RegisterClassMap((dynamic)bsonClassMap!);
        }

        return services;
    }

    private static bool IsDocumentConfiguration(Type i)
    {
        return i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IDocumentTypeConfiguration<>);
    }
}
