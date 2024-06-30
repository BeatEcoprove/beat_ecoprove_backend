using BeatEcoprove.Domain.AdvertisementAggregator.Entities;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.ProfileAggregator.Enumerators;
using BeatEcoprove.Domain.Shared.Models;

namespace BeatEcoprove.Domain.AdvertisementAggregator.Enumerators;

public class AdvertisementType : Enumeration<AdvertisementType>
{
    public static readonly AdvertisementType Voucher = new(0, typeof(Voucher));
    public static readonly AdvertisementType Advertisement = new(1, typeof(Advertisement));
    public static readonly AdvertisementType Promotion = new(2, typeof(Promotion));

    private AdvertisementType(int value, Type type)
        : base(value, type)
    {
    }

    public string GetAdvertisementType()
    {
        return Type.Name.ToLower();
    }

    public static explicit operator AdvertisementType(int v) => FromValue(v)!;

    public static explicit operator int(AdvertisementType v) => v.Value;
}