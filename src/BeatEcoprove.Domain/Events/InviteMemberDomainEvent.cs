using BeatEcoprove.Domain.GroupAggregator.Entities;
using BeatEcoprove.Domain.Shared.Models;

namespace BeatEcoprove.Domain.Events;

public record InviteMemberDomainEvent(GroupInvite Invite) : IDomainEvent;