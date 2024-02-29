using BeatEcoprove.Infrastructure.Configuration;
using BeatEcoprove.Infrastructure.Persistence.Configurations;
using BeatEcoprove.Infrastructure.Persistence.Serializers;

using Microsoft.Extensions.DependencyInjection;

using MongoDB.Driver;

namespace BeatEcoprove.Infrastructure.Persistence;

public static class MongoDbContext
{
    public static IServiceCollection SetUpMongoDb(this IServiceCollection services)
    {
        ConfigureMongoDb(services);
        services.RegisterDocumentConfigurations();
        services.RegisterSerializers();

        return services;
    }

    private static void ConfigureMongoDb(IServiceCollection services)
    {
        services.AddSingleton<IMongoClient>(new MongoClient(Env.Mongo.ConnectionString));
        services.AddScoped(provider =>
        {
            var client = provider.GetRequiredService<IMongoClient>();

            return client.GetDatabase(Env.Mongo.Database);
        });
    }
}