using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Providers;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.GroupAggregator;
using BeatEcoprove.Domain.GroupAggregator.DAOS;
using BeatEcoprove.Domain.GroupAggregator.Enumerators;
using BeatEcoprove.Domain.GroupAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.Shared.Errors;

using ErrorOr;

namespace BeatEcoprove.Infrastructure.Services;

public class GroupService : IGroupService
{
    private readonly IGroupRepository _groupRepository;
    private readonly IFileStorageProvider _fileStorageProvider;

    public GroupService(IGroupRepository groupRepository, IFileStorageProvider fileStorageProvider)
    {
        _groupRepository = groupRepository;
        _fileStorageProvider = fileStorageProvider;
    }

    public async Task<ErrorOr<GroupDao>> GetGroupAsync(Profile profile, GroupId groupId, CancellationToken cancellationToken)
    {
        // verify if profile is a member of the group
        if (!await _groupRepository.IsMemberAsync(groupId, profile.Id, cancellationToken))
        {
            return Errors.Groups.CannotAccess;
        }

        var group = await _groupRepository.GetGroupDaoAsync(groupId, cancellationToken);

        if (group is null)
        {
            return Errors.Groups.NotFound;
        }

        return group;
    }

    public async Task<Group> CreateGroupAsync(
        Profile profile,
        Group group,
        Stream avatarPicture,
        CancellationToken cancellationToken)
    {
        var avatarUrl =
            await _fileStorageProvider
                .UploadFileAsync(
                    Buckets.GroupBucket,
                    ((Guid)group.Id).ToString(),
                    avatarPicture,
                    cancellationToken);

        // Set the group avatar picture
        group.SetAvatarPicture(avatarUrl);

        // Add an admin member to the group
        group.AddMember(profile.Id, MemberPermission.Admin);

        await _groupRepository.AddAsync(group, cancellationToken);

        return group;
    }
}