using BeatEcoprove.Application.Profiles.Commands.AddBucketToCloset;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Contracts.Profile;
using BeatEcoprove.Domain.ClothAggregator;
using Mapster;

namespace BeatEcoprove.Api.Mappers;

public class ClothMappingConfiguration : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<AddBucketToProfile, AddBucketToClosetCommand>();
        
        config.NewConfig<Cloth, ClothResponse>();
        config.NewConfig<Bucket, BucketResponse>()
            .Map(
                dest => dest.AssociatedClothIds, 
                src => src.BucketClothEntries.Select(entry => entry.ClothId.Value).ToList());

        config.NewConfig<MixedClothBucketList, ClosetResponse>();
    }
}