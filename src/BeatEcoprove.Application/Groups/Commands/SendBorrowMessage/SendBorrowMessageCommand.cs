using BeatEcoprove.Application.Shared;

using ErrorOr;

namespace BeatEcoprove.Application.Groups.Commands.SendBorrowMessage;

public record SendBorrowMessageCommand(
    Guid GroupId,
    Guid UserId,
    string Message,
    Guid ClothId
) : ICommand<ErrorOr<bool>>;