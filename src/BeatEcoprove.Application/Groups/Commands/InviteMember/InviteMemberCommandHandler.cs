using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Interfaces.Persistence;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.GroupAggregator;
using BeatEcoprove.Domain.GroupAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;
using ErrorOr;

namespace BeatEcoprove.Application.Groups.Commands.InviteMember;

internal sealed class InviteMemberCommandHandler : ICommandHandler<InviteMemberCommand, ErrorOr<Group>>
{
    private readonly IProfileManager _profileManager;
    private readonly IGroupRepository _groupRepository;
    private readonly IProfileRepository _profileRepository;
    private readonly IUnitOfWork _unitOfWork;

    public InviteMemberCommandHandler(
        IProfileManager profileManager, 
        IGroupRepository groupRepository, 
        IProfileRepository profileRepository, 
        IUnitOfWork unitOfWork)
    {
        _profileManager = profileManager;
        _groupRepository = groupRepository;
        _profileRepository = profileRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<ErrorOr<Group>> Handle(InviteMemberCommand request, CancellationToken cancellationToken)
    {
        var authId = AuthId.Create(request.AuthId);
        var profileId = ProfileId.Create(request.ProfileId);
        var groupId = GroupId.Create(request.GroupId);
        var inviteeId = ProfileId.Create(request.InviteeId);

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
        
        if (!await _groupRepository.IsMemberAsync(groupId, profileId, cancellationToken))
        {
            return Errors.Groups.MemberNotFound;
        }   
        
        var invitee = await _profileRepository.GetByIdAsync(inviteeId, cancellationToken);
        
        if (invitee is null)
        {
            return Errors.User.ProfileDoesNotExists;
        }
        
        var shouldInviteUser = group.InviteMember(profile.Value.Id, invitee);
        
        if (shouldInviteUser.IsError)
        {
            return shouldInviteUser.Errors;
        }
        
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return group;
    }
}