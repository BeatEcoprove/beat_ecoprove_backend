using BeatEcoprove.Domain.GroupAggregator.Enumerators;
using BeatEcoprove.Domain.GroupAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Models;

namespace BeatEcoprove.Domain.GroupAggregator.Entities;

public class GroupMember : Entity<GroupMemberId>
{
    private GroupMember() { }

    public GroupMember(
        ProfileId profile,
        GroupId group,
        MemberPermission permission = MemberPermission.Member)
    {
        Id = GroupMemberId.CreateUnique();
        Profile = profile;
        Group = group;
        Permission = permission;
    }

    public ProfileId Profile { get; private set; } = null!;
    public GroupId Group { get; private set; } = null!;
    public MemberPermission Permission { get; private set; }

    public bool Promote(MemberPermission permission)
    {
        Permission = permission;
        return true;
    }
}