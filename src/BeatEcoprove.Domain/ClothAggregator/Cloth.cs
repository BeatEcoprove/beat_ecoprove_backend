﻿using BeatEcoprove.Domain.ClothAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.Enumerators;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Models;

namespace BeatEcoprove.Domain.ClothAggregator;

public class Cloth : AggregateRoot<ClothId, Guid>, IWearable
{
    private Cloth() { }
    
    private Cloth(
        ClothId id,
        string name,
        GarmentType type,
        GarmentSize size,
        string brand,
        string color,
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
    public GarmentType Type { get; private set; }
    public GarmentSize Size { get; private set; }
    public string Brand { get; private set; } = null!;
    public string Color { get; private set; } = null!;
    public int EcoScore { get; private set; }
    public string ClothAvatar { get; private set; } = null!;

    public static Cloth Create(
        string name,
        GarmentType type,
        GarmentSize size,
        string brand,
        string color)
    {
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
