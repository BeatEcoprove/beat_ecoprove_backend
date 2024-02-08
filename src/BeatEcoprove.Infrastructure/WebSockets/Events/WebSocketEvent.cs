using BeatEcoprove.Infrastructure.WebSockets.Contracts;
using BeatEcoprove.Infrastructure.WebSockets.Exceptions;
using MediatR;
using System.Text.Json;

namespace BeatEcoprove.Infrastructure.WebSockets.Events;

internal abstract class WebSocketEvent
{
    public abstract Task Handle();
    public static WebSocketEvent MakeEvent(string json, ISender sender)
    {
        var @event = JsonSerializer.Deserialize<WebSocketEventJson>(json);

        if (@event == null)
        {
            throw new WebSocketEventException();
        }

        return @event.Type switch
        {
            nameof(ConnectGroupEvent) => new ConnectGroupEvent(sender, json),
            _ => throw new WebSocketEventException(),
        };
    }
}
