using BeatEcoprove.Domain.GroupAggregator;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;

namespace BeatEcoprove.Application.Shared.Interfaces.Services;

public interface IGroupService
{
    Task<Group> CreateGroupAsync(
        Profile profile,
        Group group,
        Stream avatarPicture,
        CancellationToken cancellationToken);
}