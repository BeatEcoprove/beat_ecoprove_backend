using BeatEcoprove.Application.Shared;
using ErrorOr;

namespace BeatEcoprove.Application.Groups.Commands.SendTextMessage;

public record SendTextMessageCommand
(
    Guid GroupId,
    Guid UserId,
    string Message
) : ICommand<ErrorOr<bool>>;
