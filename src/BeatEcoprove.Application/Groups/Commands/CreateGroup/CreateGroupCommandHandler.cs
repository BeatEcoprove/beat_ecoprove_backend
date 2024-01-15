using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Interfaces.Persistence;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.GroupAggregator;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using ErrorOr;

namespace BeatEcoprove.Application.Groups.Commands.CreateGroup;

internal sealed class CreateGroupCommandHandler : ICommandHandler<CreateGroupCommand, ErrorOr<Group>>
{
    private readonly IProfileManager _profileManager;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IGroupService _groupService;

    public CreateGroupCommandHandler(
        IProfileManager profileManager, 
        IUnitOfWork unitOfWork, IGroupService groupService)
    {
        _profileManager = profileManager;
        _unitOfWork = unitOfWork;
        _groupService = groupService;
    }

    public async Task<ErrorOr<Group>> Handle(CreateGroupCommand request, CancellationToken cancellationToken)
    {
        var authId = AuthId.Create(request.AuthId);
        var profileId = ProfileId.Create(request.ProfileId);
        
        // validate the profile
        
        var profile = await _profileManager.GetProfileAsync(authId, profileId, cancellationToken);

        if (profile.IsError)
        {
            return profile.Errors;
        }

        var group = Group.Create(
            profile.Value.Id,
            request.Name,
            request.Description,
            request.IsPublic
        );

        var groupDao = await _groupService.CreateGroupAsync(profile.Value, group, request.AvatarPicture, cancellationToken);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        
        return groupDao;
    }
}