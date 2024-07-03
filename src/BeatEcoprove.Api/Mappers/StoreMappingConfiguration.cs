using BeatEcoprove.Contracts.Closet.Cloth;
using BeatEcoprove.Contracts.Store;
using BeatEcoprove.Contracts.ValueObjects;
using BeatEcoprove.Domain.StoreAggregator;
using BeatEcoprove.Domain.StoreAggregator.Daos;
using BeatEcoprove.Domain.StoreAggregator.Entities;
using BeatEcoprove.Domain.StoreAggregator.Enumerators;

using Mapster;

namespace BeatEcoprove.Api.Mappers;

public class StoreMappingConfiguration : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<WorkerDao, WorkerResponse>()
            .MapWith(src => new WorkerResponse(
                src.Id,
                src.Name,
                src.Email.Value,
                src.Type.ToString()
            ));
            
        config.NewConfig<Store, StoreResponse>()
            .MapWith(src => new StoreResponse(
                    src.Id,
                    src.Name,
                    src.Workers.Count,
                    src.Address.Adapt<AddressResponse>(),
                    src.SustainablePoints,
                    src.TotalRate,
                    src.Picture,
                    src.Level
                )
            );

        config.NewConfig<OrderDAO, OrderResponse>()
            .MapWith(src => CreateOrderResponse(src));
    }

    private static OrderResponse CreateOrderResponse(OrderDAO src)
    {
        if (src is OrderClothDao orderClothDao)
        {
            return CreateOrderClothResponse(orderClothDao);
        }
        
        return new OrderResponse(
            src.Id,
            src.Owner,
            ToMaintenanceOrder(src),
            nameof(src.Type).ToLower()
        );
    }
    
    private static OrderClothResponse CreateOrderClothResponse(OrderClothDao src)
    {
        return new OrderClothResponse(
            src.Id,
            src.Owner,
            ToMaintenanceOrder(src),
            nameof(src.Type).ToLower(),
            src.Cloth.Adapt<ClothResponse>()
        );
    }

    private static List<MaintenanceOrderResponse> ToMaintenanceOrder(OrderDAO src)
    {
        return src.MaintenanceServices.Select(service => new MaintenanceOrderResponse(
            service.Id,
            service.Title,
            service.Badge
        )).ToList();
    }
}