using BeatEcoprove.Application.Stores.Commands.AddStore;
using BeatEcoprove.Contracts.Store;
using BeatEcoprove.Contracts.ValueObjects;
using BeatEcoprove.Domain.StoreAggregator;

using Mapster;

namespace BeatEcoprove.Api.Mappers;

public class StoreMappingConfiguration : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<Store, StoreResponse>()
            .MapWith(src => new StoreResponse(
                    src.Id,
                    src.Name,
                    src.Workers.Count,
                    src.Address.Adapt<AddressResponse>(),
                    src.SustainablePoints,
                    src.TotalRate,
                    src.Level
                )
            );
    }
}