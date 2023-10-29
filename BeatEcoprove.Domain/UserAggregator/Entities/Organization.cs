using BeatEcoprove.Domain.UserAggregator.Enumerators;
using BeatEcoprove.Domain.UserAggregator.ValueObjects;

namespace BeatEcoprove.Domain.UserAggregator.Entities;

public sealed class Organization : User
{
    private Organization() { }

    private Organization(
        UserName userName,
        string typeOption,
        Email email,
        string name,
        Password password,
        Phone phone,
        string avatarUrl,
        Address address,
        int sustainabilityPoints,
        double xp)
        : base(email, name, password, phone, avatarUrl, UserType.Consumer)
    {
        TypeOption = typeOption;
        UserName = userName;
        Address = address;
        SustainabilityPoints = sustainabilityPoints;
        Xp = xp;
    }

    public UserName UserName { get; private set; } = null!;

    // TODO: Create a TypeOption Enum
    public string TypeOption { get; private set; } = null!;
    public Address Address { get; private set; } = null!;
    public int SustainabilityPoints { get; private set; }
    public double Xp { get; private set; }

    public static Organization Create(
        UserName userName,
        string typeOption,
        Email email,
        string name,
        Password password,
        Phone phone,
        string avatarUrl,
        Address address)
    {
        return new Organization(userName, typeOption, email, name, password, phone, avatarUrl, address, 0, 0);
    }
}