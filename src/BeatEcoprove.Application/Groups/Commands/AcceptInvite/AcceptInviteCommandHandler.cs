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

namespace BeatEcoprove.Application.Groups.Commands.AcceptInvite;

internal sealed class AcceptInviteCommandHandler : ICommandHandler<AcceptInviteCommand, ErrorOr<Group>>
{
    private readonly IProfileManager _profileManager;
    private readonly IGroupRepository _groupRepository;
    private readonly IKeyValueRepository<string> _keyValueRepository;
    private readonly IUnitOfWork _unitOfWork;

    public AcceptInviteCommandHandler(
        IProfileManager profileManager,
        IGroupRepository groupRepository,
        IKeyValueRepository<string> redis,
        IUnitOfWork unitOfWork)
    {
        _profileManager = profileManager;
        _groupRepository = groupRepository;
        _keyValueRepository = redis;
        _unitOfWork = unitOfWork;
    }

    public async Task<ErrorOr<Group>> Handle(AcceptInviteCommand request, CancellationToken cancellationToken)
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

        var codeKey = new CodeKey(profile.Value.Id, group.Id, request.Code.ToString());
        var inviteId = await _keyValueRepository.GetAndDeleteAsync(codeKey);

        if (inviteId is null)
        {
            return Errors.Groups.InviteNotFound;
        }

        var inviteGuidId = InviteGroupId.Create(Guid.Parse(inviteId.ToString()));
        var invite = await _groupRepository.GetGroupInviteAsync(groupId, inviteGuidId, cancellationToken);

        if (invite is null)
        {
            return Errors.Groups.InviteNotFound;
        }

        var shouldAccept = group.AcceptInvite(invite, true);

        if (shouldAccept.IsError)
        {
            return shouldAccept.Errors;
        }

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return group;
    }
}