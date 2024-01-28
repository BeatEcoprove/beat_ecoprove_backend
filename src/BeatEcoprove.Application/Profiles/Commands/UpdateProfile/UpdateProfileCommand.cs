using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using ErrorOr;

namespace BeatEcoprove.Application.Profiles.Commands.UpdateProfile;

public record UpdateProfileCommand
(
    Guid AuthId,
    Guid ProfileId,
    string? Username,
    string? Email,
    string? Phone,
    string? PhoneCountryCode,
    Stream AvatarPicture
) : ICommand<ErrorOr<Profile>>, IAuthorization;