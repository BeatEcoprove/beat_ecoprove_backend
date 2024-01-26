using BeatEcoprove.Domain.GroupAggregator.Enumerators;
using BeatEcoprove.Domain.GroupAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Models;

namespace BeatEcoprove.Domain.GroupAggregator.Entities;

public class GroupInvite : Entity<InviteGroupId>
{
    public GroupInvite(
        GroupId group, 
        ProfileId inviter,
        ProfileId target,
        MemberPermission permission = MemberPermission.Member)
    {
        Id = InviteGroupId.CreateUnique();
        Target = target;
        Group = group;
        Inviter = inviter;
        CreatedAt = DateTime.UtcNow;
        Permission = permission;
    }

    public ProfileId Target { get; private set; }
    public GroupId Group { get; private set; }
    public ProfileId Inviter { get; private set; }
    public MemberPermission Permission { get; set; }
    public DateTime CreatedAt { get; private set; }
    public DateTime? AcceptedAt { get; private set; }
    public DateTime? DeclinedAt { get; private set; }
    
    public void Accept()
    {
        AcceptedAt = DateTime.UtcNow;
    }
    
    public void Decline()
    {
        DeclinedAt = DateTime.UtcNow;
    }
}