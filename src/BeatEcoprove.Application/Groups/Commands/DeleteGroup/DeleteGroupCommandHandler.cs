using BeatEcoprove.Application.Shared;
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

namespace BeatEcoprove.Application.Groups.Commands.DeleteGroup;

internal sealed class DeleteGroupCommandHandler : ICommandHandler<DeleteGroupCommand, ErrorOr<Group>>
{
    private readonly IProfileManager _profileManager;
    private readonly IGroupRepository _groupRepository;
    private readonly IUnitOfWork _unitOfWork;

    public DeleteGroupCommandHandler(
        IProfileManager profileManager,
        IGroupRepository groupRepository,
        IUnitOfWork unitOfWork)
    {
        _profileManager = profileManager;
        _groupRepository = groupRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<ErrorOr<Group>> Handle(DeleteGroupCommand request, CancellationToken cancellationToken)
    {
        var authId = AuthId.Create(request.AuthId);
        var profileId = ProfileId.Create(request.ProfileId);
        var groupId = GroupId.Create(request.GroupId);

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

        var actionMember = group.GetMemberByProfileId(profile.Value.Id);

        if (actionMember is null)
        {
            return Errors.Groups.DontBelongToGroup;
        }

        if (actionMember.Permission != MemberPermission.Admin)
        {
            return Errors.Groups.PermissionNotValid;
        }

        await _groupRepository.RemoveGroupAsync(group, cancellationToken);
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return group;
    }
}