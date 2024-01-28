using BeatEcoprove.Application.FeedBacks.Commands.Common;
using BeatEcoprove.Contracts.FeedBacks;
using BeatEcoprove.Contracts.Profile;
using Mapster;

namespace BeatEcoprove.Api.Mappers;

public class FeedBackMappingConfiguration : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<FeedBackResult, FeedBackResponse>()
            .MapWith(src => new FeedBackResponse(
                src.Id,
                src.Sender.Adapt<ProfileResponse>(),
                src.Title,
                src.Description
            ));
    }
}