using BeatEcoprove.Domain.ProfileAggregator.Entities;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Models;

namespace BeatEcoprove.Domain.ProfileAggregator;

public class Auth : AggregateRoot<AuthId, Guid>
{
    private Auth()
    {
    }

    private Auth(
        AuthId authId,
        Email email,
        Password password,
        string salt,
        bool isEnabled)
    {
        Id = authId;
        Email = email;
        Password = password;
        Salt = salt;
        IsEnabled = isEnabled;
    }

    public Email Email { get; set; } = null!;
    public Password Password { get; set; } = null!;
    public string Salt { get; set; } = null!;
    public bool IsEnabled { get; set; }

    public static Auth Create(
        Email email,
        Password password)
    {
        return new(
            AuthId.CreateUnique(),
            email,
            password,
            "",
            false);
    }
}
