using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.Enumerators;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;

namespace BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;

public class Consumer : Profile
{
    private Consumer() { }

    private Consumer(
        AuthId authId,
        UserName userName,
        Phone phone,
        double xP,
        int sustainabilityPoints,
        int ecoScore,
        string avatarUrl,
        DateOnly bornDate,
        Gender gender)
        : base(authId, userName, phone, xP, sustainabilityPoints, ecoScore, avatarUrl, UserType.Consumer)
    {
        BornDate = bornDate;
        Gender = gender;
    }

    public DateOnly BornDate { get; private set; }
    public Gender Gender { get; private set; }

    public static Consumer Create(
        AuthId authId,
        UserName userName,
        Phone phone,
        string avatarUrl,
        DateOnly bornDate,
        Gender gender)
    {
        return new(
            authId,
            userName,
            phone,
            0.0,
            0,
            0,
            avatarUrl,
            bornDate,
            gender);
    }
}
