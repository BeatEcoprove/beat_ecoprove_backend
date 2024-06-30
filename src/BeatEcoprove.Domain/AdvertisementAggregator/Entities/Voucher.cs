using BeatEcoprove.Domain.AdvertisementAggregator.Enumerators;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;

namespace BeatEcoprove.Domain.AdvertisementAggregator.Entities;

public class Voucher : Advertisement
{
    private Voucher()
    {
    }

    private Voucher(
        ProfileId creator, 
        string title, 
        string description, 
        DateTimeOffset initDate, 
        DateTimeOffset endDate, 
        string picture, 
        int sustainablePoints,
        int quantity) : base(creator, title, description, initDate, endDate, picture, sustainablePoints)
    {
        Quantity = quantity;
    }

    public override AdvertisementType Type => AdvertisementType.Voucher;
    public int Quantity { get; private set; } = 0;

    public static Voucher Create(
        ProfileId creator, 
        string title, 
        string description, 
        DateTimeOffset initDate, 
        DateTimeOffset endDate, 
        string picture, 
        int sustainablePoints,
        int quantity
    )
    {
        return new Voucher(
            creator,
            title,
            description, 
            initDate, 
            endDate, 
            picture, 
            sustainablePoints, 
            quantity
        );
    }
}