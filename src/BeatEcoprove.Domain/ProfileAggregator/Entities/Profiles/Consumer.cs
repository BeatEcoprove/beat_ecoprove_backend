using BeatEcoprove.Domain.ProfileAggregator.Enumerators;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;

namespace BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;

public class Consumer : Profile
{
    private Consumer() { }

    private Consumer(
        UserName userName,
        Phone phone,
        double xP,
        int sustainabilityPoints,
        int ecoScore,
        DateOnly bornDate,
        Gender gender)
        : base(userName, phone, xP, sustainabilityPoints, ecoScore, UserType.Consumer)
    {
        BornDate = bornDate;
        Gender = gender;
    }

    public DateOnly BornDate { get; private set; }
    public Gender Gender { get; private set; }

    public static Consumer Create(
        UserName userName,
        Phone phone,
        DateOnly bornDate,
        Gender gender)
    {
        return new Consumer(
            userName,
            phone,
            0.0,
            0,
            0,
            bornDate,
            gender);
    }
}
