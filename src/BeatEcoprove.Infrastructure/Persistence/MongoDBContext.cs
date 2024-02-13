using BeatEcoprove.Domain.ProfileAggregator.Entities.Notifications;
using BeatEcoprove.Infrastructure.Persistence.Configurations.Notifications;
using BeatEcoprove.Infrastructure.Persistence.Serializers;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Bson.Serialization;
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

        ConfigureMongoDB();
        services.AddSingleton<IMongoClient>(new MongoClient($"mongodb://{mongoUser}:{mongoPassword}@{mongoDbHost}:{mongoPort}/{mongoDb}"));
        services.AddScoped(provider =>
        {
            var client = provider.GetRequiredService<IMongoClient>();

            return client.GetDatabase(mongoDb);
        });

        return services;
    }

    private static void ConfigureMongoDB()
    {
        SerializersExtension
                    .RegisterDocumentSerializers();

        SerializersExtension
            .RegisterEntitySerializers();

        BsonClassMap.RegisterClassMap<Notification>(
            map => new NotificationConfiguration().Configure(map));

        BsonClassMap.RegisterClassMap<InviteNotification>(
           map => new InviteNotificationConfiguration().Configure(map));

        BsonClassMap.RegisterClassMap<LeveUpNotification>(
            map => new LevelUpNotificationConfiguration().Configure(map));
    }
}
