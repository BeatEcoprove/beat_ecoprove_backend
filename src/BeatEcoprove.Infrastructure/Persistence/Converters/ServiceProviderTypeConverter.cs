using BeatEcoprove.Domain.StoreAggregator.Enumerators;

using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BeatEcoprove.Infrastructure.Persistence.Converters;

public class ServiceProviderTypeConverter : ValueConverter<ServiceProviderType, int>
{
    public ServiceProviderTypeConverter() : base(
            v => v,
            v => (ServiceProviderType)v)
    { }
}