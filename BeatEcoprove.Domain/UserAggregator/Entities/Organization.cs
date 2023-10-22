using BeatEcoprove.Domain.UserAggregator.Enumerators;
using BeatEcoprove.Domain.UserAggregator.ValueObjects;

namespace BeatEcoprove.Domain.UserAggregator.Entities;

public sealed class Organization : User
{
    private Organization(
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
        Address = address;
        SustainabilityPoints = sustainabilityPoints;
        Xp = xp;
    }

    public Address Address { get; private set; }
    public int SustainabilityPoints { get; private set; }
    public double Xp { get; private set; }
    
    public static Organization Create(
        Email email, 
        string name, 
        Password password, 
        Phone phone, 
        string avatarUrl,
        Address address,
        int sustainabilityPoints,
        double xp)
    {
        return new Organization(email, name, password, phone, avatarUrl, address, sustainabilityPoints, xp);
    }
}