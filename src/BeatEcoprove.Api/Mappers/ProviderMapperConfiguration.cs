using BeatEcoprove.Contracts.Providers;
using BeatEcoprove.Contracts.Store;
using BeatEcoprove.Domain.ProfileAggregator.DAOS;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;

using Mapster;

namespace BeatEcoprove.Api.Mappers;

public class ProviderMapperConfiguration : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<ProviderDao, ProviderResponse>()
            .MapWith(src => new ProviderResponse(
                src.ProviderId,
                src.Title,
                src.Picture,
                src.Type.ToString().ToLower(),
                src.Services.Select(service => new MaintenanceOrderResponse(
                    service.Id,
                    service.Title,
                    service.Badge
                )).ToList(),
                src.TotalRanking
            ));
        
        config.NewConfig<Organization, StandardProviderResponse>()
            .MapWith(src => new StandardProviderResponse(
                src.Id,
                src.AvatarUrl,
                src.UserName,
                src.TypeOption.ToString()   
            ));
    }
}