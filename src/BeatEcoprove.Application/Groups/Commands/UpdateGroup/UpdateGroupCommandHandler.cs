using ErrorOr;
using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Application.Shared.Interfaces.Persistence;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Providers;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.GroupAggregator;
using BeatEcoprove.Domain.GroupAggregator.Enumerators;
using BeatEcoprove.Domain.GroupAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;

namespace BeatEcoprove.Application.Groups.Commands.UpdateGroup;

internal sealed class UpdateGroupCommandHandler : ICommandHandler<UpdateGroupCommand, ErrorOr<Group>>
{
    private readonly IProfileManager _profileManager;
    private readonly IGroupRepository _groupRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IFileStorageProvider _fileStorage;

    public UpdateGroupCommandHandler(
        IProfileManager profileManager, 
        IGroupRepository groupRepository, 
        IUnitOfWork unitOfWork, 
        IFileStorageProvider fileStorage)
    {
        _profileManager = profileManager;
        _groupRepository = groupRepository;
        _unitOfWork = unitOfWork;
        _fileStorage = fileStorage;
    }

    public async Task<ErrorOr<Group>> Handle(UpdateGroupCommand request, CancellationToken cancellationToken)
    {
        var authId = AuthId.Create(request.AuthId);
        var profileId = ProfileId.Create(request.ProfileId);
        var groupId = GroupId.Create(request.GroupId);
        var memberId = ProfileId.Create(request.MemberId);

        var profile = await _profileManager.GetProfileAsync(authId, profileId, cancellationToken);

        if (profile.IsError)
        {
            return profile.Errors;
        }
        
        var group = await _groupRepository.GetByIdAsync(groupId, cancellationToken);
        
        if (group is null)
        {
            return Errors.Groups.NotFound;
        }
        
        var actionMember = group.GetMemberByProfileId(memberId);

        if (actionMember is null)
        {
            return Errors.Groups.DontBelongToGroup;
        }
            
        if (actionMember.Permission != MemberPermission.Admin)
        {
            return Errors.Groups.CannotAccess;
        }
        
        group.SetName(request.Name ?? group.Name);
        group.SetDescription(request.Description ?? group.Description);
        group.SetGroupState(request.IsPublic ?? group.IsPublic);

        if (request.PictureStream != Stream.Null)
        {
            var avatarUrl = 
                await _fileStorage
                    .UploadFileAsync(
                        Buckets.GroupBucket,
                        ((Guid)groupId).ToString(), 
                        request.PictureStream, 
                        cancellationToken);
            
            group.SetAvatarPicture(avatarUrl);
        }
        
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return group;
    }
}