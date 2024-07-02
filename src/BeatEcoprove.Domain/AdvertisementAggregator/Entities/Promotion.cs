using BeatEcoprove.Domain.AdvertisementAggregator.Enumerators;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;

namespace BeatEcoprove.Domain.AdvertisementAggregator.Entities;

public sealed class Promotion : Advertisement
{
    private const int AddCost = 100;
    
    private Promotion()
    {
    }

    private Promotion(
        ProfileId creator, 
        string title, 
        string description, 
        DateTimeOffset initDate, 
        DateTimeOffset endDate, 
        int sustainablePoints) : base(creator, title, description, initDate, endDate, sustainablePoints)
    {
        Type = AdvertisementType.Promotion;
    }

    public static new Promotion Create(
        ProfileId creator, 
        string title, 
        string description, 
        DateTimeOffset initDate, 
        DateTimeOffset endDate)
    {
        return new Promotion(
            creator,
            title,
            description, 
            initDate, 
            endDate, 
            AddCost
        );
    }
}