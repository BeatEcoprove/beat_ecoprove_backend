using BeatEcoprove.Application.Shared;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using ErrorOr;

namespace BeatEcoprove.Application.Profiles.Commands.DeleteNestedProfile;

public record DeleteNestedProfileCommand
(
    Guid AuthId,
    Guid ProfileId
) : ICommand<ErrorOr<Profile>>;