using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Infrastructure.Configuration;

using Microsoft.Extensions.DependencyInjection;

using StackExchange.Redis;

namespace BeatEcoprove.Infrastructure.Persistence;

public static class RedisContext
{
    public static IServiceCollection SetUpRedis(
       this IServiceCollection services)
    {
        services.AddScoped(cfg =>
        {
            var options = new ConfigurationOptions
            {
                EndPoints = { Env.Redis.ConnectionString },
                AbortOnConnectFail = false,
                ConnectTimeout = 5000,
            };

            IConnectionMultiplexer multiplexer = ConnectionMultiplexer.Connect(options);
            var database = multiplexer.GetDatabase(db: Env.Redis.Database);

            return database;
        });

        services.AddScoped<IKeyValueRepository<string>, KeyValueRepository>();

        return services;
    }
}