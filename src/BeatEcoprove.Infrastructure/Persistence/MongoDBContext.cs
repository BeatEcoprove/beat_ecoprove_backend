using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;

namespace BeatEcoprove.Infrastructure.Persistence;

public static class MongoDBContext
{
    public static IServiceCollection SetUpMongoDb(this IServiceCollection services)
    {
        var mongoDbHost = Environment.GetEnvironmentVariable("MONGO_HOST") ?? "localhost";
        var mongoPort = Environment.GetEnvironmentVariable("MONGO_PORT") ?? "27017";
        var mongoUser = Environment.GetEnvironmentVariable("MONGO_USER") ?? "beat";
        var mongoPassword = Environment.GetEnvironmentVariable("MONGO_PASSWORD") ?? "password";
        var mongoDb = Environment.GetEnvironmentVariable("MONGO_DB") ?? "ecoprove";

        services.AddSingleton<IMongoClient>(new MongoClient($"mongodb://{mongoUser}:{mongoPassword}@{mongoDbHost}:{mongoPort}/{mongoDb}"));
        services.AddScoped(provider =>
        {
            var client = provider.GetRequiredService<IMongoClient>();
            return client.GetDatabase(mongoDb);
        });

        return services;
    }
}
