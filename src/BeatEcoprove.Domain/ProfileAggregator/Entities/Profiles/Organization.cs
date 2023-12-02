using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.Enumerators;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;

namespace BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;


public class Organization : Profile
{
    private Organization()
    {
    }

    private Organization(
        UserName userName,
        Phone phone,
        double xP,
        int sustainabilityPoints,
        int ecoScore,
        Address address)
        : base(userName, phone, xP, sustainabilityPoints, ecoScore, UserType.Organization)
    {
        Address = address;
        TypeOption = TypeOption.Washer;
    }

    public Address Address { get; private set; } = null!;
    public TypeOption TypeOption { get; private set; }

    public static Organization Create(
        UserName userName,
        Phone phone,
        Address address)
    {
        return new Organization(
            userName,
            phone,
            0.0,
            0,
            0,
            address);
    }
}
