using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Providers;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.GroupAggregator;
using BeatEcoprove.Domain.GroupAggregator.Enumerators;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;

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
        group.AddMember(profile, MemberPermission.Admin);
        
        await _groupRepository.AddAsync(group, cancellationToken);

        return group;
    }
}