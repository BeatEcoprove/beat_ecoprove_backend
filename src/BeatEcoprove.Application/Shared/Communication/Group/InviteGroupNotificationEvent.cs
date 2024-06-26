﻿using BeatEcoprove.Domain.ProfileAggregator.Entities.Notifications;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;

namespace BeatEcoprove.Application.Shared.Communication.Group;

public class InviteGroupNotificationEvent :
    NotificationEvent<InviteGroupContent>, INotifer
{
    public InviteGroupNotificationEvent
        (ProfileId to, InviteGroupContent content) : base(to, content)
    {
    }

    public Notification GetNotification()
    {
        return InviteNotification.Create(
            Content.Message,
            Content.Group,
            Content.GroupName,
            Content.From,
            Owner,
            Content.Code
        );
    }

    public override string Type => nameof(InviteGroupNotificationEvent);
}