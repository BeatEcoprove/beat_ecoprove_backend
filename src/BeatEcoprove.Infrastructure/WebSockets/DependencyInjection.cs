using BeatEcoprove.Application.Shared.Interfaces.Providers;
using BeatEcoprove.Application.Shared.Interfaces.Websockets;
using Microsoft.Extensions.DependencyInjection;

namespace BeatEcoprove.Infrastructure.WebSockets;

public static class DependencyInjection
{
    public static IServiceCollection AddWebSocketImpl(this IServiceCollection services)
    {
        services.AddSingleton<ISessionManager, SessionManager>();
        services.AddSingleton<IGroupSessionManager, GroupSessionManager>();

        services.AddScoped<IWebSocketManager, WebSocketHandler>();
        services.AddScoped<INotificationSender>(
           provider => provider.GetService<WebSocketHandler>()!);

        return services;
    }
}
