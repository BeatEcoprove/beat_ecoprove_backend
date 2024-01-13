using BeatEcoprove.Application.Shared;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using ErrorOr;

namespace BeatEcoprove.Application.Profiles.Commands.PromoteProfileToAccount;

public record PromoteProfileToAccountCommand
(
    Guid AuthId,
    Guid ProfileId,
    string Email,
    string Password
) : ICommand<ErrorOr<Profile>>;