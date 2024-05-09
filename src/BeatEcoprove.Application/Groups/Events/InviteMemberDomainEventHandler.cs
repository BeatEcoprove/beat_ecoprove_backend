using BeatEcoprove.Application.Shared.Communication.Group;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Providers;
using BeatEcoprove.Domain.Events;
using BeatEcoprove.Domain.GroupAggregator.ValueObjects;

using MediatR;

namespace BeatEcoprove.Application.Groups.Events;

public class InviteMemberDomainEventHandler : INotificationHandler<InviteMemberDomainEvent>
{
    private readonly INotificationSender _notificationSender;
    private readonly INotificationRepository _notificationRepository;
    private readonly IJwtProvider _jwtProvider;
    private readonly IGroupRepository _groupRepository;
    private readonly IKeyValueRepository<string> _keyValueRespository;

    public InviteMemberDomainEventHandler(
        INotificationSender notificationSender,
        INotificationRepository notificationRepository,
        IJwtProvider jwtProvider,
        IKeyValueRepository<string> redis,
        IGroupRepository groupRepository)
    {
        _notificationSender = notificationSender;
        _jwtProvider = jwtProvider;
        _keyValueRespository = redis;
        _groupRepository = groupRepository;
        _notificationRepository = notificationRepository;
    }

    public async Task Handle(InviteMemberDomainEvent notification, CancellationToken cancellationToken)
    {
        var invitation = notification.Invite;
        var groupId = GroupId.Create(invitation.Group);

        if (await _notificationRepository.ThereIsAnyInviteForUserOnGroup(groupId, invitation.Target, cancellationToken))
        {
            return;
        }

        var inviteCode = _jwtProvider.GenerateRandomCode(6);

        var inviteKey = new CodeKey(invitation.Target, invitation.Group, inviteCode);
        await _keyValueRespository.AddAsync(inviteKey, invitation.Id.Value.ToString());

        var group = await _groupRepository.GetByIdAsync(groupId, cancellationToken);

        if (group is null)
        {
            return;
        }

        await _notificationSender.SendNotificationAsync(
            new InviteGroupNotificationEvent(
                invitation.Target,
                new InviteGroupContent(
                    inviteCode,
                    invitation.Group,
                    group.Name,
                    invitation.Inviter
                )
            ),
            cancellationToken
        );
    }
}