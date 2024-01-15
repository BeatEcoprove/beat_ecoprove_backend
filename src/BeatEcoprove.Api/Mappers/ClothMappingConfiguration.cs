using BeatEcoprove.Application.Closet.Commands.CreateBucket;
using BeatEcoprove.Application.Closet.Common;
using BeatEcoprove.Application.Cloths.Queries.Common;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Contracts.Closet;
using BeatEcoprove.Contracts.Closet.Bucket;
using BeatEcoprove.Contracts.Closet.Cloth;
using BeatEcoprove.Contracts.Services;
using BeatEcoprove.Domain.ClosetAggregator;
using Mapster;

namespace BeatEcoprove.Api.Mappers;

public class ClothMappingConfiguration : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<Cloth, ClothResult>();
        
        config.NewConfig<CreateBucketRequest, CreateBucketCommand>();
        
        config.NewConfig<ClothMaintenanceStatus, ClothMaintenanceStatusResponse>()
            .MapWith(src => new ClothMaintenanceStatusResponse(
                src.Cloth.Adapt<ClothResponse>(),
                new MaintenanceSelectorResponse(
                    src.Service.Id,
                    src.Service.Title,
                    src.Service.Badge,
                    src.Service.Description,
                    src.Action.Adapt<MaintenanceActionResponse>()
                ),
                src.MaintenanceActivityId,
                src.Status
            ));
        
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

        return clothesInBucket.Select(cloth => cloth.Adapt<ClothResponse>()).ToList();
    }

    private BucketResponse ToBucketResponse(Bucket bucket, List<ClothResult> cloths)
    {
       return new BucketResponse(
           bucket.Id,
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