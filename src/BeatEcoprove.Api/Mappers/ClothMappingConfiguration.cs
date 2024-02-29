using BeatEcoprove.Application.Closet.Commands.CreateBucket;
using BeatEcoprove.Application.Closet.Common;
using BeatEcoprove.Application.Cloths.Queries.Common;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Contracts.Closet;
using BeatEcoprove.Contracts.Closet.Bucket;
using BeatEcoprove.Contracts.Profile;
using BeatEcoprove.Contracts.Services;
using BeatEcoprove.Domain.ClosetAggregator;
using BeatEcoprove.Domain.ClosetAggregator.DAOs;

using Mapster;

using ClothResponse = BeatEcoprove.Contracts.Closet.Cloth.ClothResponse;

namespace BeatEcoprove.Api.Mappers;

public class ClothMappingConfiguration : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<Cloth, ClothResult>();
        config.NewConfig<ClothResult, ClothResponse>();
        config.NewConfig<ClothResultExtension, ClothResponse>()
            .MapWith(src => new ClothResponse(
                src.Id,
                src.Name,
                src.Type,
                src.Size,
                src.Brand,
                src.Color,
                src.EcoScore,
                src.ClothState,
                src.ClothAvatar,
                src.Profile.Adapt<ProfileClosetResponse>()
            ));

        config.NewConfig<ClothDao, ClothResult>()
            .MapWith(src => new ClothResult(
                src.Id,
                src.Name,
                src.Type,
                src.Size,
                src.Brand,
                src.Color,
                src.EcoScore,
                src.ClothState,
                src.ClothAvatar
            ));

        config.NewConfig<ClothDaoWithProfile, ClothResultExtension>()
            .MapWith(src => new ClothResultExtension(
                src.Id,
                src.Name,
                src.Type,
                src.Size,
                src.Brand,
                src.Color,
                src.EcoScore,
                src.ClothState,
                src.ClothAvatar,
                src.Profile
            ));

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

    private List<ClothResponse> ConvertCloth<T>(List<T> cloths, Bucket bucket)
        where T : IClothResult
    {
        var clothesInBucket = cloths
            .Where(cloth => bucket.BucketClothEntries.Any(entry => entry.ClothId == cloth.Id))
            .ToList();

        return clothesInBucket.Select(cloth => cloth.Adapt<ClothResponse>()).ToList();
    }

    private BucketResponse ToBucketResponse<T>(Bucket bucket, List<T> cloths)
        where T : IClothResult
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
            source.Cloths.Select(cloth =>
            {
                if (cloth is ClothResultExtension clothDao)
                {
                    return clothDao.Adapt<ClothResponse>();
                }

                return cloth.Adapt<ClothResponse>();
            }).ToList(),
            bucketResponses
        );
    }

}