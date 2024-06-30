using BeatEcoprove.Domain.Shared.Models;
using BeatEcoprove.Domain.StoreAggregator.Entities;

namespace BeatEcoprove.Domain.StoreAggregator.Enumerators;
public class ServiceProviderType : Enumeration<ServiceProviderType>
{
    public static readonly ServiceProviderType Store = new(0, typeof(Store));

    private ServiceProviderType(int value, Type type)
        : base(value, type)
    {
    }

    public string GetServiceProviderType()
    {
        return Type.Name.ToLower();
    }

    public static explicit operator ServiceProviderType(int v) => FromValue(v)!;

    public static explicit operator int(ServiceProviderType v) => v.Value;
}
