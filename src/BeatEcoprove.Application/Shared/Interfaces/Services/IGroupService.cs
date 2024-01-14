using BeatEcoprove.Domain.GroupAggregator;
using BeatEcoprove.Domain.GroupAggregator.DAOS;
using BeatEcoprove.Domain.GroupAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using ErrorOr;

namespace BeatEcoprove.Application.Shared.Interfaces.Services;

public interface IGroupService
{
    Task<ErrorOr<GroupDao>> GetGroupAsync(
        Profile profile,
        GroupId groupId,
        CancellationToken cancellationToken);
    
    Task<Group> CreateGroupAsync(
        Profile profile,
        Group group,
        Stream avatarPicture,
        CancellationToken cancellationToken);
}