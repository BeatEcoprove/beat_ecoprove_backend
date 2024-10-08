using BeatEcoprove.Application.Shared;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;

using ErrorOr;

namespace BeatEcoprove.Application.Authentication.Commands.DeleteAccount;

public record DeleteAccountCommand
(
    Guid AuthId,
    Guid ProfileId
) : ICommand<ErrorOr<AuthId>>;