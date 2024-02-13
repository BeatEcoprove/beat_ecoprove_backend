using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;
using StackExchange.Redis;

namespace BeatEcoprove.Infrastructure.Persistence;

public static class RedisContext
{
    public static IServiceCollection SetUpRedis(
       this IServiceCollection services)
    {
        var redisHost = Environment.GetEnvironmentVariable("REDIS_HOST") ?? "localhost";
        var redisPort = Environment.GetEnvironmentVariable("REDIS_PORT") ?? "6379";

        services.AddScoped(cfg =>
        {
            var options = new ConfigurationOptions
            {
                EndPoints = { $"{redisHost}:{redisPort}" },
                AbortOnConnectFail = false,
                ConnectTimeout = 5000,
            };

            IConnectionMultiplexer multiplexer = ConnectionMultiplexer.Connect(options);
            var database = multiplexer.GetDatabase(db: 0);

            return database;
        });

        services.AddScoped<IKeyValueRepository<string>, KeyValueRepository>();

        return services;
    }
}
