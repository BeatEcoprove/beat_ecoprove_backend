using BeatEcoprove.Contracts.Profile;
using BeatEcoprove.Contracts.Store;
using BeatEcoprove.Contracts.ValueObjects;
using BeatEcoprove.Domain.StoreAggregator;
using BeatEcoprove.Domain.StoreAggregator.Daos;
using BeatEcoprove.Domain.StoreAggregator.Entities;
using BeatEcoprove.Domain.StoreAggregator.Enumerators;

using Mapster;

using ClothResponse = BeatEcoprove.Contracts.Closet.Cloth.ClothResponse;

namespace BeatEcoprove.Api.Mappers;

public class StoreMappingConfiguration : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<RatingDao, RatingResponse>()
            .MapWith(src => new RatingResponse(
                src.Id,
                src.Rating,
                new ProfileClosetResponse(
                    src.Profile.Id,
                    src.Profile.UserName,
                    src.Profile.AvatarUrl
                )
            ));
        
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
                    src.NumberWorkers,
                    src.Address.Adapt<AddressResponse>(),
                    src.SustainablePoints,
                    src.GetTotalRating(),
                    src.Picture,
                    src.Level,
                    new CoordinatesResponse(
                        src.Localization.X,
                        src.Localization.Y
                    )
                )
            );

        config.NewConfig<OrderDAO, OrderResponse>()
            .MapWith(src => (CreateOrderResponse(src) as OrderResponse)!);
    }

    public static dynamic CreateOrderResponse(OrderDAO src)
    {
        if (src is OrderClothDao orderClothDao)
        {
            return CreateOrderClothResponse(orderClothDao);
        }
        
        return new OrderResponse(
            src.Id,
            new ProfileClosetResponse(
                src.Owner.Id,
                src.Owner.UserName,
                src.Owner.AvatarUrl
            ),
            ToMaintenanceOrder(src),
            src.Type.Type.Name.ToLower()
        );
    }
    
    private static OrderClothResponse CreateOrderClothResponse(OrderClothDao src)
    {
        return new OrderClothResponse(
            src.Id,
            new ProfileClosetResponse(
                src.Owner.Id,
                src.Owner.UserName,
                src.Owner.AvatarUrl
            ),
            ToMaintenanceOrder(src),
             src.Type.Type.Name.ToLower(),
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