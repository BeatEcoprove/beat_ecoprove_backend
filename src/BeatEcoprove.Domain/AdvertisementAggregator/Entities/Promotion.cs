using BeatEcoprove.Domain.AdvertisementAggregator.Enumerators;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;

namespace BeatEcoprove.Domain.AdvertisementAggregator.Entities;

public class Promotion : Advertisement
{
    private Promotion()
    {
    }

    private Promotion(
        ProfileId creator, 
        string title, 
        string description, 
        DateTimeOffset initDate, 
        DateTimeOffset endDate, 
        string picture, 
        int sustainablePoints) : base(creator, title, description, initDate, endDate, picture, sustainablePoints)
    {
    }

    public override AdvertisementType Type => AdvertisementType.Promotion;

    public static new Promotion Create(
        ProfileId creator, 
        string title, 
        string description, 
        DateTimeOffset initDate, 
        DateTimeOffset endDate, 
        string picture, 
        int sustainablePoints)
    {
        return new Promotion(
            creator,
            title,
            description, 
            initDate, 
            endDate, 
            picture, 
            sustainablePoints
        );
    }
}