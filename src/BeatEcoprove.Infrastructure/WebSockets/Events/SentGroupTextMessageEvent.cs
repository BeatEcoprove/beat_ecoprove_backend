using System.Text.Json;

using BeatEcoprove.Application.Groups.Commands.SendTextMessage;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Infrastructure.WebSockets.Contracts;

using ErrorOr;

using MediatR;

namespace BeatEcoprove.Infrastructure.WebSockets.Events;

internal class SentGroupTextMessageEvent : WebSocketEvent
{
    private readonly ISender _sender;
    private readonly SendGroupTextMessageEventJson _event;
    private readonly ProfileId _userId;

    public SentGroupTextMessageEvent(
        ISender sender,
        string @event,
        ProfileId userId)
    {
        var jsonResult = JsonSerializer.Deserialize<SendGroupTextMessageEventJson>(@event);

        if (jsonResult == null)
        {
            throw new ArgumentNullException(nameof(jsonResult));
        }

        _sender = sender;
        _event = jsonResult;
        _userId = userId;
    }

    public override async Task<ErrorOr<bool>> Handle(CancellationToken cancellation = default)
    {
        return await _sender.Send(
            new SendTextMessageCommand(
                _event.GroupId,
                _userId,
                _event.Message
            ),
            cancellation
        );
    }
}