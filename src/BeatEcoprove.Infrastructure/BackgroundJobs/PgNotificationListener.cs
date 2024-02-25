using System.Text.Json;
using BeatEcoprove.Application.Shared.Communication.LevelUp;
using BeatEcoprove.Application.Shared.Interfaces.Providers;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Npgsql;

namespace BeatEcoprove.Infrastructure.BackgroundJobs;

public class PgNotificationListener : BackgroundService
{
    private const string Channel = "level_up";
    private readonly DbSettings _dbSettings;
    private readonly IServiceProvider _serviceProvider;

    public PgNotificationListener(
        IOptions<DbSettings> dbSettings,
        IServiceProvider serviceProvider)
    {
        _dbSettings = dbSettings.Value;
        _serviceProvider = serviceProvider;
    }
    
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        await using var connection = new NpgsqlConnection(_dbSettings.ConnectionString);
        await connection.OpenAsync(stoppingToken);
        
        await using var command = new NpgsqlCommand($"LISTEN {Channel};", connection);
        await command.ExecuteNonQueryAsync(stoppingToken);

        connection.Notification += HandleNotification;
        
        while (!stoppingToken.IsCancellationRequested)
        {
            try
            {
                await connection.WaitAsync(stoppingToken);
            }
            catch (PostgresException ex)
            {
                Console.WriteLine(ex.Message);
                break;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                break;
            }
        }
    }

    private void HandleNotification(object sender, NpgsqlNotificationEventArgs e)
    {
        using var scope = _serviceProvider.CreateScope();
        var notificationSender = scope.ServiceProvider.GetRequiredService<INotificationSender>();
        
        Console.WriteLine($"Received notification: {e.Payload}");
        var payload = JsonSerializer.Deserialize<PgLevelUpNotification>(e.Payload);

        if (payload == null)
        {
            return;
        }

        Task.Run(() => notificationSender.SendNotificationAsync(
            new LevelUpNotificationEvent(
                ProfileId.Create(Guid.Parse(payload!.Id!)),
                new LevelUpContent(
                    payload.Level,
                    payload.Xp
                )
            ),
            cancellationToken: default
           ));
    }
}