using BeatEcoprove.Domain.AdvertisementAggregator.Enumerators;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;

using ErrorOr;

namespace BeatEcoprove.Domain.AdvertisementAggregator.Entities;

public sealed class Voucher : Advertisement
{
    private const int AddCost = 10;
    
    private Voucher()
    {
    }

    private Voucher(
        ProfileId creator, 
        string title, 
        string description, 
        DateTimeOffset initDate, 
        DateTimeOffset endDate, 
        int sustainablePoints,
        int quantity) : base(creator, title, description, initDate, endDate, sustainablePoints)
    {
        Quantity = quantity;
        Type = AdvertisementType.Voucher;
    }

    public int Quantity { get; private set; } = 0;

    public static ErrorOr<Advertisement> Create(
        ProfileId creator, 
        string title, 
        string description, 
        DateTimeOffset initDate, 
        DateTimeOffset endDate, 
        int quantity
    ) {
        if (quantity == 0)
        {
            return Errors.Advertisement.VoucherQuantityBelow0;
        }
        
        return new Voucher(
            creator,
            title,
            description, 
            initDate, 
            endDate, 
            AddCost * quantity, 
            quantity
        );
    }
}