using BeatEcoprove.Contracts.Advertisements;
using BeatEcoprove.Domain.AdvertisementAggregator;

using Mapster;

namespace BeatEcoprove.Api.Mappers;

public class AdvertisementMappingConfiguration : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<Advertisement, AdvertisementResponse>()
            .MapWith(src => new AdvertisementResponse(
                src.Id,
                src.Title,
                src.Description,
                src.Picture,
                src.InitDate,
                src.EndDate,
                src.Type.Type.Name.ToLower()
            ));
    }
}