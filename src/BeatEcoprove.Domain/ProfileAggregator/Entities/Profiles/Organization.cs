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
        AuthId authId,
        UserName userName,
        Phone phone,
        double xP,
        int sustainabilityPoints,
        int ecoScore,
        string avatarUrl,
        Address address)
        : base(authId, userName, phone, xP, sustainabilityPoints, ecoScore, avatarUrl, UserType.Organization)
    {
        Address = address;
        TypeOption = TypeOption.Washer;
    }

    public Address Address { get; private set; } = null!;
    public TypeOption TypeOption { get; private set; }

    public static Organization Create(
        AuthId authId,
        UserName userName,
        Phone phone,
        string avatarUrl,
        Address address)
    {
        return new(
            authId,
            userName,
            phone,
            0.0,
            0,
            0,
            avatarUrl,
            address);
    }
}
