using BeatEcoprove.Infrastructure.WebSockets.Contracts;
using MediatR;
using System.Text.Json;

namespace BeatEcoprove.Infrastructure.WebSockets.Events;

internal class ConnectGroupEvent : WebSocketEvent
{
    private readonly ISender _sender;
    private readonly WebSocketEventJson _event;

    public ConnectGroupEvent(
        ISender sender,
        string @event)
    {
        var jsonResult = JsonSerializer.Deserialize<ConnectGroupEventJson>(@event);

        if (jsonResult == null)
        {
            throw new ArgumentNullException(nameof(jsonResult));
        }

        _sender = sender;
        _event = jsonResult;
    }

    public override async Task Handle()
    {
        await _sender.Send(new
        {
            Event = _event
        });
    }
}