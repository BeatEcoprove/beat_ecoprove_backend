using BeatEcoprove.Domain.ClosetAggregator;
using BeatEcoprove.Domain.ClosetAggregator.DAOs;
using BeatEcoprove.Domain.Shared.Entities;
using BeatEcoprove.Domain.StoreAggregator.Daos;
using BeatEcoprove.Domain.StoreAggregator.Entities;

namespace BeatEcoprove.Infrastructure.Extensions;

public static class MappersExtensions
{
    public static OrderDAO ToOrderDao(this Order order)
    {
        return new OrderDAO(
            order.Id,
            order.Store,
            order.Owner,
            order.Status,
            order.AcceptedAt,
            order.Type
        );
    }

    public static OrderClothDao ToOrderCloth(this OrderCloth order, Cloth cloth, Brand brand, Color color)
    {
        return new OrderClothDao(
           order.Id,
           order.Store,
           order.Owner,
           order.Status,
           order.AcceptedAt,
           order.Type,
           cloth.ToClothDao(
               brand,
               color
            )
        );
    }
    
    public static ClothDao ToClothDao(this Cloth cloth, Brand brand, Color color)
    {
        return new ClothDao(
            cloth.Id,
            cloth.Name,
            cloth.Type.ToString(),
            cloth.Size.ToString(),
            brand.Name,
            color.Hex,
            cloth.EcoScore,
            cloth.State.ToString(),
            cloth.ClothAvatar
        );
    }
}