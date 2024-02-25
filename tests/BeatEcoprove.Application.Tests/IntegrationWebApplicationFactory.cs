using System.Data.Common;
using BeatEcoprove.Infrastructure;
using BeatEcoprove.Infrastructure.Persistence;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Respawn;
using Testcontainers.PostgreSql;

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
    
    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        builder.ConfigureTestServices(services =>
        {
            var descriptor = services
                .SingleOrDefault(s => 
                    s.ServiceType == typeof(DbContextOptions<BeatEcoproveDbContext>));

            if (descriptor is not null)
            {
                services.Remove(descriptor);
            }

            var dbSettings = new DbSettings()
            {
                ConnectionString = _dbContainer.GetConnectionString()
            };
            
            services.AddSingleton(Options.Create(dbSettings));
            services.AddDbContext<BeatEcoproveDbContext>(options =>
            {
                options.UseNpgsql(dbSettings.ConnectionString);
            });
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

    public new Task DisposeAsync()
    {
        return _dbContainer.StopAsync();
    }
}
