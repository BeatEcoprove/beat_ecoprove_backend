using BeatEcoprove.Contracts.Providers;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;

using Mapster;

namespace BeatEcoprove.Api.Mappers;

public class ProviderMapperConfiguration : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<Organization, StandardProviderResponse>()
            .MapWith(src => new StandardProviderResponse(
                src.AvatarUrl,
                src.UserName,
                src.TypeOption.ToString()   
            ));
    }
}