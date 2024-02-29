using System.Text.Json;

using BeatEcoprove.Application.Shared.Communication.LevelUp;
using BeatEcoprove.Application.Shared.Interfaces.Providers;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Infrastructure.Persistence.Shared;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using Npgsql;

namespace BeatEcoprove.Infrastructure.BackgroundJobs;

public class PgNotificationListener : BackgroundService
{
    private const string Channel = "level_up";
    private readonly IServiceProvider _serviceProvider;

    public PgNotificationListener(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        using var scope = _serviceProvider.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<IApplicationDbContext>();
        var connectionString = dbContext.GetConnectionString();

        await using var connection = new NpgsqlConnection(connectionString);
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