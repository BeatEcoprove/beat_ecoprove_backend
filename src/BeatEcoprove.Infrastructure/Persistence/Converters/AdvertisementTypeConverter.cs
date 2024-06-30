using BeatEcoprove.Domain.AdvertisementAggregator.Enumerators;
using BeatEcoprove.Domain.ProfileAggregator.Enumerators;
using BeatEcoprove.Domain.StoreAggregator.ValueObjects;

using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BeatEcoprove.Infrastructure.Persistence.Converters;

public class AdvertisementTypeConverter : ValueConverter<AdvertisementType, int>
{
    public AdvertisementTypeConverter() : base(
            v => v,
            v => (AdvertisementType)v)
    { }
}