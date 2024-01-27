using BeatEcoprove.Domain.Events;
using BeatEcoprove.Domain.GroupAggregator.Entities;
using BeatEcoprove.Domain.GroupAggregator.Enumerators;
using BeatEcoprove.Domain.GroupAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;
using BeatEcoprove.Domain.Shared.Models;
using ErrorOr;

namespace BeatEcoprove.Domain.GroupAggregator;

public class Group : AggregateRoot<GroupId, Guid>
{
    private readonly List<GroupMember> _members = new();
    private readonly List<GroupInvite> _invites = new();
    private readonly List<TextMessage> _textMessages = new();
    
    private Group() { }

    private Group(
        GroupId id,
        ProfileId creatorId,
        string name,
        string description,
        int sustainablePoints,
        double xp,
        bool isPublic)
    {
        Id = id;
        CreatorId = creatorId;
        Name = name;
        Description = description;
        SustainablePoints = sustainablePoints;
        Xp = xp;
        IsPublic = isPublic;
        MembersCount = _members.Count;
    }

    public string Name { get; private set; } = null!;
    public string Description { get; private set; } = null!;

    public int MembersCount { get; private set; }
    public int SustainablePoints { get; private set; }
    public double Xp { get; private set; }
    public bool IsPublic { get; private set; }
    public string AvatarPicture { get; private set; } = null!;
    public ProfileId CreatorId { get; private set; } = null!;
    public IReadOnlyList<TextMessage> TextMessages => _textMessages.AsReadOnly();
    public IReadOnlyList<GroupMember> Members => _members.AsReadOnly();
    public IReadOnlyList<GroupInvite> Invites => _invites.AsReadOnly();

    public static Group Create(
        ProfileId creatorId,
        string name,
        string description,
        bool isPublic)
    {
        return new(
            GroupId.CreateUnique(), 
            creatorId,
            name,
            description,
            0,
            0,
            isPublic);
    }
    
    public void SetAvatarPicture(string avatarPicture)
    {
        AvatarPicture = avatarPicture;
    }

    public void AddMember(Profile profile, MemberPermission permission = MemberPermission.Member) 
    {
        this._members.Add(new GroupMember(
            profile.Id,
            this.Id,
            permission
        ));
        
        MembersCount = _members.Count;
    }

    public GroupMember? GetMemberByProfileId(ProfileId profileId)
    {
        return this._members.FirstOrDefault(member => member.Profile == profileId);
    }
    
    public ErrorOr<bool> PromoteMember(GroupMemberId memberId, MemberPermission role)
    {
        var member = this._members.FirstOrDefault(member => member.Id == memberId);

        if (member is null)
        {
            return Errors.Groups.MemberNotFound;
        }
        
        if (member.Permission == role)
        {
            return Errors.Groups.CannotPromoteToSameRole;
        }

        return member.Promote(role);
    }
    
    public List<GroupMember> GetAdmins()
    {
        return this._members
            .Where(member => member.Permission == MemberPermission.Admin)
            .ToList();
    }

    public bool KickMember(GroupMember member)
    {
        MembersCount--;
        return this._members.Remove(member);
    }
    
    public void SetGroupState(bool isPublic)
    {
        IsPublic = isPublic;
    }
    
    public void SetName(string name)
    {
        Name = name;
    }
    
    public void SetDescription(string description)
    {
        Description = description;
    }
    
    public ErrorOr<bool> AddTextMessage(ProfileId profileId, string message)
    {
        var groupMember = GetMemberByProfileId(profileId);
        
        if (groupMember is null)
        {
            return Errors.Groups.MemberNotFound;
        }
        
        this._textMessages.Add(new TextMessage(
            this.Id,
            groupMember.Id,
            message
            ));

        return true;
    }

    public ErrorOr<GroupInvite> InviteMember(ProfileId from, Profile to)
    {
        if (this._members.Any(m => m.Profile == to.Id))
        {
            return Errors.Groups.MemberAlreadyExists;
        }

        var invite = new GroupInvite(
            this.Id,
            from,
            to.Id
        );
        
        this._invites.Add(invite);
        this.AddDomainEvent(new InviteMemberDomainEvent(invite));
        
        return invite;
    }

    public ErrorOr<bool> AcceptInvite(GroupInvite invite, bool accept)
    {
        invite = this._invites
            .First(i => i.Id == invite.Id);
        
        if (invite.AcceptedAt is not null || invite.DeclinedAt is not null)
        {
            return Errors.Groups.InviteAlreadyUsed;
        }
        
        if (!accept)
        {
            invite.Decline();
            return false;
        }
        
        var member = new GroupMember(
            invite.Target,
            invite.Group,
            invite.Permission
        );
        
        invite.Accept();
        this._members.Add(member);
        this._invites.Remove(invite);
        
        return true;
    }
}