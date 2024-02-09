using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Infrastructure.WebSockets.Contracts;
using BeatEcoprove.Infrastructure.WebSockets.Exceptions;
using ErrorOr;
using MediatR;
using System.Net.WebSockets;
using System.Text.Json;

namespace BeatEcoprove.Infrastructure.WebSockets.Events;

internal abstract class WebSocketEvent
{
    public abstract Task<ErrorOr<bool>> Handle(CancellationToken cancellation = default);
    public static WebSocketEvent MakeEvent(
        ProfileId userId,
        WebSocket userSocket,
        string json, 
        ISender sender)
    {
        var @event = JsonSerializer.Deserialize<WebSocketEventJson>(json);

        if (@event == null)
        {
            throw new WebSocketEventException();
        }

        return @event.Type switch
        {
            nameof(ConnectGroupEvent) => new ConnectGroupEvent(sender, json, userId, userSocket),
            nameof(SentGroupTextMessageEvent) => new SentGroupTextMessageEvent(sender, json, userId),
            _ => throw new WebSocketEventException(),
        };
    }
}
