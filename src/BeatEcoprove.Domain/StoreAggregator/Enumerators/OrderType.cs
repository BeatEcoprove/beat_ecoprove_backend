using BeatEcoprove.Domain.Shared.Models;
using BeatEcoprove.Domain.StoreAggregator.Entities;

namespace BeatEcoprove.Domain.StoreAggregator.ValueObjects;
public class OrderType : Enumeration<OrderType>
{
    public static readonly OrderType Cloth = new(0, typeof(OrderCloth));
    public static readonly OrderType Bucket = new(1, typeof(OrderBucket));

    private OrderType(int value, Type type)
        : base(value, type)
    {
    }

    public string GetOrderType()
    {
        return Type.Name.ToLower();
    }

    public static explicit operator OrderType(int v) => FromValue(v)!;

    public static explicit operator int(OrderType v) => v.Value;
}
