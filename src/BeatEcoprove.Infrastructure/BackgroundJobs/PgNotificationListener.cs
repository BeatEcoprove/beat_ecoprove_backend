using System.Text.Json;
using System.Text.Json.Serialization;
using BeatEcoprove.Application.Shared.Interfaces.Providers;
using BeatEcoprove.Infrastructure.WebSockets.Notifications;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Npgsql;

namespace BeatEcoprove.Infrastructure.BackgroundJobs;

public class PgNotificationListener : BackgroundService
{
    private const string Channel = "level_up";
    private readonly DbSettings _dbSettings;
    private readonly IWebSocketsHandler _socketsHandler;

    public PgNotificationListener(
        IOptions<DbSettings> dbSettings, 
        IWebSocketsHandler socketsHandler)
    {
        _socketsHandler = socketsHandler;
        _dbSettings = dbSettings.Value;
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
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    private void HandleNotification(object sender, NpgsqlNotificationEventArgs e)
    {
        Console.WriteLine($"Received notification: {e.Payload}");
        var payload = JsonSerializer.Deserialize<LevelUpNotification>(e.Payload);

        if (payload == null)
        {
            return;
        }

        Task.Run(() =>
            _socketsHandler.SendNotificationToUser(Guid.Parse(payload!.Id!), new SendLevelNotification
                (payload.Id, payload.Level)));
    }
}