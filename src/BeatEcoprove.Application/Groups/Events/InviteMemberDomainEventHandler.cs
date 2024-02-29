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
    private readonly IJwtProvider _jwtProvider;
    private readonly IKeyValueRepository<string> _keyValueRespository;

    public InviteMemberDomainEventHandler(
        INotificationSender notificationSender,
        IJwtProvider jwtProvider,
        IKeyValueRepository<string> redis)
    {
        _notificationSender = notificationSender;
        _jwtProvider = jwtProvider;
        _keyValueRespository = redis;
    }

    public async Task Handle(InviteMemberDomainEvent notification, CancellationToken cancellationToken)
    {
        var invitation = notification.Invite;

        var inviteCode = _jwtProvider.GenerateRandomCode(6);

        var inviteKey = new CodeKey(invitation.Target, invitation.Group, inviteCode);
        await _keyValueRespository.AddAsync(inviteKey, invitation.Id.Value.ToString());

        await _notificationSender.SendNotificationAsync(
            new InviteGroupNotificationEvent(
                invitation.Target,
                new InviteGroupContent(
                    inviteCode,
                    invitation.Group,
                    invitation.Inviter
                )
            ),
            cancellationToken
        );
    }
}