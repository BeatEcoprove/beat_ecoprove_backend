using BeatEcoprove.Domain.UserAggregator.Enumerators;
using BeatEcoprove.Domain.UserAggregator.ValueObjects;

namespace BeatEcoprove.Domain.UserAggregator.Entities;

public sealed class Consumer : User
{
    private readonly List<Profile> _profiles = new();
    private Consumer(
        Email email, 
        string name, 
        Password password, 
        Phone phone, 
        string avatarUrl,
        Profile mainProfile) 
        : base(email, name, password, phone, avatarUrl, UserType.Consumer)
    {
        _profiles.Add(mainProfile);
        MainProfile = mainProfile;
    }
    
    public Profile MainProfile { get; private set; }
    
    public IReadOnlyList<Profile> AttachedProfiles => _profiles;
    
    public static Consumer Create(
        Email email, 
        string name, 
        Password password, 
        Phone phone, 
        string avatarUrl,
        UserName userName,
        Gender gender,
        DateOnly bornDate,
        int xp,
        double sustainabilityPoints,
        double ecoScore)
    {
        var profile = Profile.Create(
            userName,
            gender,
            xp,
            bornDate,
            sustainabilityPoints,
            ecoScore,
            avatarUrl
        );
        
        return new Consumer(email, name, password, phone, avatarUrl, profile);
    }
}