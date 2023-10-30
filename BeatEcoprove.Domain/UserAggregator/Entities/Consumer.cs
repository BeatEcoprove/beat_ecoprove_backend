using BeatEcoprove.Domain.UserAggregator.Enumerators;
using BeatEcoprove.Domain.UserAggregator.ValueObjects;

namespace BeatEcoprove.Domain.UserAggregator.Entities;

public sealed class Consumer : User
{
    private readonly List<Profile> _profiles = new();

    private Consumer() { }

    private Consumer(
        Email email,
        string name,
        Password password,
        Phone phone,
        string avatarUrl)
        : base(email, name, password, phone, avatarUrl, UserType.Consumer)
    {
    }

    public Profile MainProfile => _profiles.FirstOrDefault()!;

    public IReadOnlyList<Profile> Profiles => _profiles.AsReadOnly();

    public static Consumer Create(
        Email email,
        string name,
        Password password,
        Phone phone,
        string avatarUrl,
        UserName userName,
        Gender gender,
        DateOnly bornDate)
    {
        var consumer = new Consumer(email, name, password, phone, avatarUrl);

        var profile = Profile.Create(
                  consumer.Id,
                  userName,
                  gender,
                  bornDate,
                  avatarUrl
              );

        consumer.AttachProfile(profile);
        return consumer;
    }

    public void AttachProfile(Profile profile)
    {
        if (_profiles.Count == 0)
        {
            profile.SetAsMainProfile();
        }

        _profiles.Add(profile);
    }
}