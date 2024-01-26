using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Extensions;
using BeatEcoprove.Application.Shared.Interfaces.Persistence;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.GroupAggregator;
using BeatEcoprove.Domain.GroupAggregator.Enumerators;
using BeatEcoprove.Domain.GroupAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;
using ErrorOr;

namespace BeatEcoprove.Application.Groups.Commands.PromoteMember;

internal sealed class PromoteMemberCommandHandler : ICommandHandler<PromoteMemberCommand, ErrorOr<Group>>
{
    private readonly IProfileManager _profileManager;
    private readonly IGroupRepository _groupRepository;
    private readonly IUnitOfWork _unitOfWork;

    public PromoteMemberCommandHandler(
        IProfileManager profileManager, 
        IGroupRepository groupRepository, 
        IUnitOfWork unitOfWork)
    {
        _profileManager = profileManager;
        _groupRepository = groupRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<ErrorOr<Group>> Handle(PromoteMemberCommand request, CancellationToken cancellationToken)
    {
        var authId = AuthId.Create(request.AuthId);
        var profileId = ProfileId.Create(request.ProfileId);
        var memberId = ProfileId.Create(request.MemberId);
        var groupId = GroupId.Create(request.GroupId);
        
        if (!request.Role.CanConvertToEnum(out MemberPermission role))
        {
            return Errors.Groups.PermissionNotValid;
        }
        
        var profile = await _profileManager.GetProfileAsync(authId, profileId, cancellationToken);

        if (profile.IsError)
        {
            return profile.Errors;
        }
        
        if (memberId == profile.Value.Id)
        {
            return Errors.Groups.CannotPromoteYourself;
        }
        
        var group = await _groupRepository.GetByIdAsync(groupId, cancellationToken);

        if (group is null)
        {
            return Errors.Groups.NotFound;
        }
        
        if (!await _groupRepository.IsProfileAdminOrOwnerAsync(groupId, profile.Value.Id, cancellationToken))
        {
            return Errors.Groups.CannotAccess;
        }
        
        var actionMember = group.GetMemberByProfileId(profile.Value.Id);
        
        if (actionMember is null)
        {
            return Errors.Groups.MemberNotFound;
        }
        
        if (actionMember.Permission != MemberPermission.Admin)
        {
            return Errors.Groups.CannotPromoteMember;
        }
        
        var member = group.GetMemberByProfileId(memberId);
        
        if (member is null)
        {
            return Errors.Groups.MemberNotFound;
        }
        
        var shouldPromoteUser = group.PromoteMember(member.Id, role);

        if (shouldPromoteUser.IsError)
        {
            return shouldPromoteUser.Errors;
        }
        
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return group;
    }
}