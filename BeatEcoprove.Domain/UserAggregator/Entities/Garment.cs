using BeatEcoprove.Domain.Shared.Models;
using BeatEcoprove.Domain.UserAggregator.ValueObjects;

namespace BeatEcoprove.Domain;

public class Garment : Entity<GarmentId>
{
    private Garment() { }

    private Garment(
        ProfileId profile,
        string name,
        GarmentType type,
        GarmentSize size,
        string brand,
        string color,
        bool isBlocked,
        double ecscore,
        string clothAvatar)
    {
        Id = GarmentId.CreateUnique();
        Profile = profile;
        Name = name;
        Type = type;
        Size = size;
        Brand = brand;
        Color = color;
        IsBlocked = isBlocked;
        Ecscore = ecscore;
        ClothAvatar = clothAvatar;
    }

    public ProfileId Profile { get; private set; } = null!;
    public string Name { get; private set; } = null!;
    public GarmentType Type { get; private set; }
    public GarmentSize Size { get; private set; }
    public string Brand { get; private set; } = null!;
    public string Color { get; private set; } = null!;
    public bool IsBlocked { get; private set; }
    public double Ecscore { get; private set; }
    public string ClothAvatar { get; private set; } = null!;

    public static Garment Create(
        ProfileId profile,
        string name,
        GarmentType type,
        GarmentSize size,
        string brand,
        string color,
        bool isBlocked,
        double ecscore,
        string clothAvatar)
    {
        return new(
            profile,
            name,
            type,
            size,
            brand,
            color,
            isBlocked,
            ecscore,
            clothAvatar);
    }
}
