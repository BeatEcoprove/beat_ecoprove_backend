using BeatEcoprove.Application.Shared.Communication.Group;
using BeatEcoprove.Application.Shared.Interfaces.Providers;
using BeatEcoprove.Domain.Events;
using MediatR;
using StackExchange.Redis;

namespace BeatEcoprove.Application.Groups.Events;

public class InviteMemberDomainEventHandler : INotificationHandler<InviteMemberDomainEvent>
{
    private readonly INotificationSender _notificationSender;
    private readonly IJwtProvider _jwtProvider;
    private readonly IDatabase _redis;

    public InviteMemberDomainEventHandler(
        INotificationSender notificationSender, 
        IJwtProvider jwtProvider, 
        IDatabase redis)
    {
        _notificationSender = notificationSender;
        _jwtProvider = jwtProvider;
        _redis = redis;
    }

    public async Task Handle(InviteMemberDomainEvent notification, CancellationToken cancellationToken)
    {
        var invitation = notification.Invite;

        var inviteCode = _jwtProvider.GenerateRandomCode(6);
        await _redis.StringAppendAsync(inviteCode, invitation.Id.Value.ToString());
        await _redis.KeyExpireAsync(inviteCode, TimeSpan.FromDays(7));

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