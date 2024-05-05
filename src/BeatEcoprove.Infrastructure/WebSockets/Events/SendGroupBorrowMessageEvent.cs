using System.Text.Json;

using BeatEcoprove.Application.Groups.Commands.SendBorrowMessage;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Infrastructure.WebSockets.Contracts;

using ErrorOr;

using MediatR;

namespace BeatEcoprove.Infrastructure.WebSockets.Events;

internal class SendGroupBorrowMessageEvent : WebSocketEvent
{
    private readonly ISender _sender;
    private readonly SendGroupBorrowMessageEventJson _event;
    private readonly ProfileId _userId;

    public SendGroupBorrowMessageEvent(
        ISender sender, 
        string @event, 
        ProfileId userId)
    {
        var jsonResult = JsonSerializer.Deserialize<SendGroupBorrowMessageEventJson>(@event);
        
        _sender = sender;
        _event = jsonResult ?? throw new ArgumentNullException(nameof(jsonResult));
        _userId = userId;
    }

    public override async Task<ErrorOr<bool>> Handle(CancellationToken cancellation = default)
    {
        return await _sender.Send(
            new SendBorrowMessageCommand(
                _event.GroupId,
                _userId,
                _event.Message,
                _event.ClothId
                ),
            cancellation
        );
    }
}