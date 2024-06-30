using BeatEcoprove.Domain.AdvertisementAggregator.Enumerators;
using BeatEcoprove.Domain.ProfileAggregator.Enumerators;
using BeatEcoprove.Domain.StoreAggregator.Enumerators;
using BeatEcoprove.Domain.StoreAggregator.ValueObjects;

using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BeatEcoprove.Infrastructure.Persistence.Converters;

public class ServiceProviderTypeConverter : ValueConverter<ServiceProviderType, int>
{
    public ServiceProviderTypeConverter() : base(
            v => v,
            v => (ServiceProviderType)v)
    { }
}