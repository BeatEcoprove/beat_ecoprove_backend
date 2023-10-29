using BeatEcoprove.Domain.Shared.Models;
using BeatEcoprove.Domain.UserAggregator.Enumerators;
using BeatEcoprove.Domain.UserAggregator.ValueObjects;

namespace BeatEcoprove.Domain.UserAggregator;

public abstract class User : AggregateRoot<UserId, Guid>
{
    protected User() { }

    protected User(
        Email email,
        string name,
        Password password,
        Phone phone,
        string avatarUrl,
        UserType type)
    {
        Id = UserId.CreateUnique();
        Email = email;
        Name = name;
        Password = password;
        Phone = phone;
        AvatarUrl = avatarUrl;
        Type = type;
    }

    public Email Email { get; private set; } = null!;
    public string Name { get; private set; } = null!;
    public Password Password { get; private set; } = null!;
    public Phone Phone { get; private set; } = null!;
    public string AvatarUrl { get; private set; } = null!;
    public UserType Type { get; private set; } = null!;
}