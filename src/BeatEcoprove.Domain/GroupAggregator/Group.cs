using BeatEcoprove.Domain.GroupAggregator.Entities;
using BeatEcoprove.Domain.GroupAggregator.Enumerators;
using BeatEcoprove.Domain.GroupAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Models;

namespace BeatEcoprove.Domain.GroupAggregator;

public class Group : AggregateRoot<GroupId, Guid>
{
    private readonly List<GroupMember> _members = new();
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
    public string AvatarPicture { get; private set; }
    public ProfileId CreatorId { get; private set; }
    public IReadOnlyList<TextMessage> TextMessages => _textMessages.AsReadOnly();
    public IReadOnlyList<GroupMember> Members => _members.AsReadOnly();

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

    public List<GroupMember> GetAdmins()
    {
        return this._members
            .Where(member => member.Permission == MemberPermission.Admin)
            .ToList();
    }
}