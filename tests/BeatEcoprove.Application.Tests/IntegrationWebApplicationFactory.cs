using BeatEcoprove.Application.Shared.Interfaces.Providers;
using BeatEcoprove.Application.Tests.Shared.Mocks;
using BeatEcoprove.Infrastructure.Persistence;


using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MongoDB.Driver;
using Respawn;
using StackExchange.Redis;
using Testcontainers.MongoDb;
using Testcontainers.PostgreSql;
using Testcontainers.Redis;

using Env = BeatEcoprove.Infrastructure.Configuration.Env;

namespace BeatEcoprove.Application.Tests;

// ReSharper disable once ClassNeverInstantiated.Global
public class IntegrationWebApplicationFactory : WebApplicationFactory<Program>, IAsyncLifetime
{
    private Respawner _respawner = default!;

    private readonly PostgreSqlContainer _dbContainer = new PostgreSqlBuilder()
        .WithImage("postgres:latest")
        .WithDatabase("ecoprove")
        .WithUsername("sa")
        .WithPassword("password")
        .Build();

    private readonly RedisContainer _redisContainer = new RedisBuilder()
        .WithImage("redis:latest")
        .Build();

    private readonly MongoDbContainer _mongoDbContainer = new MongoDbBuilder()
        .WithImage("mongo:latest")
        .WithUsername("beat")
        .WithPassword("password")
        .Build();

    protected override IHostBuilder? CreateHostBuilder()
    {
        Env.Postgres.ConnectionString = _dbContainer.GetConnectionString();
        Env.Redis.ConnectionString = _redisContainer.GetConnectionString();
        Env.Mongo.ConnectionString = _mongoDbContainer.GetConnectionString();
        
        return base.CreateHostBuilder();
    }

    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        builder.ConfigureTestServices(services =>
        {
            ConfigureDbContext(services);
            ConfigureRedis(services);
            ConfigureMailSender(services);
            ConfigureMongoDb(services);
        });
    }

    private void ConfigureMongoDb(IServiceCollection services)
    {
        var descriptor = services
            .SingleOrDefault(s =>
                s.ServiceType == typeof(IMongoClient));

        if (descriptor is not null)
        {
            services.Remove(descriptor);
        }

        services.AddSingleton<IMongoClient>
            (new MongoClient(_mongoDbContainer.GetConnectionString()));
    }

    private static void ConfigureMailSender(IServiceCollection services)
    {
        var descriptor = services
            .SingleOrDefault(s =>
                s.ServiceType == typeof(IMailSender));

        if (descriptor is not null)
        {
            services.Remove(descriptor);
        }

        services.AddScoped<IMailSender, MailSenderMock>();
    }

    private void ConfigureRedis(IServiceCollection services)
    {
        var descriptor = services
            .SingleOrDefault(s =>
                s.ServiceType == typeof(IDatabase));

        if (descriptor is not null)
        {
            services.Remove(descriptor);
        }

        var redisVars = _redisContainer.GetConnectionString().Split(":");
        services.AddScoped(cfg =>
        {
            var options = new ConfigurationOptions
            {
                EndPoints = { $"{redisVars[0]}:{redisVars[1]}" },
                AbortOnConnectFail = false,
                ConnectTimeout = 5000,
            };

            IConnectionMultiplexer multiplexer = ConnectionMultiplexer.Connect(options);
            var database = multiplexer.GetDatabase(db: 0);

            return database;
        });
    }

    private void ConfigureDbContext(IServiceCollection services)
    {
        var descriptor = services
            .SingleOrDefault(s =>
                s.ServiceType == typeof(DbContextOptions<BeatEcoproveDbContext>));

        if (descriptor is not null)
        {
            services.Remove(descriptor);
        }

        services.AddDbContext<BeatEcoproveDbContext>(options =>
        {
            options.UseNpgsql(_dbContainer.GetConnectionString());
        });
    }

    public async Task ResetDatabaseAsync()
    {
        using var scope = Services.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<BeatEcoproveDbContext>();

        var dbConnection = dbContext.Database.GetDbConnection();
        await dbConnection.OpenAsync();

        await _respawner.ResetAsync(dbConnection);
    }

    public async Task InitializeAsync()
    {
        await _dbContainer.StartAsync();
        await _redisContainer.StartAsync();
        await _mongoDbContainer.StartAsync();

        await InitiateDbConnection();
    }

    private async Task InitiateDbConnection()
    {
        using var scope = Services.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<BeatEcoproveDbContext>();
        await dbContext.Database.MigrateAsync();

        var dbConnection = dbContext.Database.GetDbConnection();
        await dbConnection.OpenAsync();

        _respawner = await Respawner.CreateAsync(dbConnection, new RespawnerOptions()
        {
            DbAdapter = DbAdapter.Postgres,
            SchemasToInclude = new[] { "public" }
        });
    }

    public new async Task DisposeAsync()
    {
        await _redisContainer.StopAsync();
        await _mongoDbContainer.StopAsync();
        await _dbContainer.StopAsync();
    }
}