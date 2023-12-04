using BeatEcoprove.Domain.ClosetAggregator.Entities;
using BeatEcoprove.Domain.ClosetAggregator.Enumerators;
using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;
using BeatEcoprove.Domain.Shared.Models;
using BeatEcoprove.Domain.Shared.ValueObjects;
using ErrorOr;

namespace BeatEcoprove.Domain.ClosetAggregator;

public class Cloth : AggregateRoot<ClothId, Guid>
{
    private readonly List<Activity> _activities = new();
    private Cloth() { }

    private Cloth(
        ClothId id,
        string name,
        ClothType type,
        ClothSize size,
        BrandId brand,
        ColorId color,
        int ecoScore)
    {
        Id = id;
        Name = name;
        Type = type;
        Size = size;
        Brand = brand;
        Color = color;
        EcoScore = ecoScore;
    }

    public string Name { get; private set; } = null!;
    public ClothType Type { get; private set; }
    public ClothSize Size { get; private set; }
    public BrandId Brand { get; private set; } = null!;
    public ColorId Color { get; private set; } = null!;
    public int EcoScore { get; private set; }
    public string ClothAvatar { get; private set; } = null!;
    public IReadOnlyList<Activity> Activities => _activities.AsReadOnly();

    public static ErrorOr<Cloth> Create(
        string name,
        ClothType type,
        ClothSize size,
        BrandId brand,
        ColorId color)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            return Errors.Cloth.InvalidClothType;
        }
        
        return new Cloth(
            ClothId.CreateUnique(),
            name,
            type,
            size,
            brand,
            color,
            0);
    }

    public void SetClothPicture(string clothAvatar)
    {
        ClothAvatar = clothAvatar;
    }
}
