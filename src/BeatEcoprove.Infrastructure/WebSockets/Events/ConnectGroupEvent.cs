using BeatEcoprove.Application.Groups.Queries.ConnectToGroup;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Infrastructure.WebSockets.Contracts;
using ErrorOr;
using MediatR;
using System.Net.WebSockets;
using System.Text.Json;

namespace BeatEcoprove.Infrastructure.WebSockets.Events;

internal class ConnectGroupEvent : WebSocketEvent
{
    private readonly ISender _sender;
    private readonly ConnectGroupEventJson _event;
    private readonly ProfileId _userId;
    private readonly WebSocket _userSocket;

    public ConnectGroupEvent(
        ISender sender,
        string @event,
        ProfileId userId,
        WebSocket userSocket)
    {
        var jsonResult = JsonSerializer.Deserialize<ConnectGroupEventJson>(@event);

        if (jsonResult == null)
        {
            throw new ArgumentNullException(nameof(jsonResult));
        }

        _sender = sender;
        _event = jsonResult;
        _userId = userId;
        _userSocket = userSocket;
    }

    public override async Task<ErrorOr<bool>> Handle(CancellationToken cancellation = default)
    {
        return await _sender.Send(new
            ConnectToGroupQuery(
                _event.GroupId,
                _userId,
                _userSocket
            ), 
            cancellation
        );
    }
}