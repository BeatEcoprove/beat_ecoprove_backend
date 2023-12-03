using BeatEcoprove.Application.Closet.Commands.CreateBucket;
using BeatEcoprove.Application.Closet.Common;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Contracts.Closet;
using BeatEcoprove.Contracts.Closet.Bucket;
using BeatEcoprove.Contracts.Closet.Cloth;
using BeatEcoprove.Domain.ClosetAggregator;
using Mapster;

namespace BeatEcoprove.Api.Mappers;

public class ClothMappingConfiguration : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<Cloth, ClothResult>();
        
        config.NewConfig<CreateBucketRequest, CreateBucketCommand>();

        config.NewConfig<BucketResult, BucketResponse>()
            .MapWith(src => ToBucketResponse(src.Bucket, src.Cloths));
        
        config.NewConfig<MixedClothBucketList, ClosetResponse>()
            .MapWith((source) => ToClosetResponse(source));
    }

    private List<ClothResponse> ConvertCloth(List<ClothResult> cloths, Bucket bucket)
    {
        var clothesInBucket = cloths
            .Where(cloth => bucket.BucketClothEntries.Any(entry => entry.ClothId == cloth.Id))
            .ToList();

        cloths.RemoveAll(cloth => clothesInBucket.Any(clothInBucket => clothInBucket.Id == cloth.Id));

        return clothesInBucket.Select(cloth => cloth.Adapt<ClothResponse>()).ToList();
    }

    private BucketResponse ToBucketResponse(Bucket bucket, List<ClothResult> cloths)
    {
       return new BucketResponse(
            bucket.Name,
            ConvertCloth(cloths, bucket));
    }
    
    private ClosetResponse ToClosetResponse(MixedClothBucketList source)
    {
        var bucketResponses = source.Buckets
            .Select(bucket => ToBucketResponse(bucket, source.Cloths))
            .ToList();

        return new ClosetResponse(
            source.Cloths.Adapt<List<ClothResponse>>(),
            bucketResponses
        );
    }

}