using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using ErrorOr;

namespace BeatEcoprove.Application.Profiles.Commands.CreateNestedProfile;

public record CreateNestedProfileCommand
(
    Guid AuthId,
    string Name,
    DateOnly BornDate,
    string Gender,
    string UserName,
    Stream AvatarPicture
) : ICommand<ErrorOr<Profile>>;