using BeatEcoprove.Application.Shared;

using ErrorOr;

namespace BeatEcoprove.Application.Groups.Commands.AcceptBorrowCloth;

public record AcceptBorrowCommand
(
    Guid AuthId,
    Guid ProfileId,
    string MessageId
) : ICommand<ErrorOr<string>>;