using BeatEcoprove.Application.Closet.Common;
using BeatEcoprove.Domain.ClosetAggregator;
using BeatEcoprove.Domain.ClosetAggregator.Enumerators;
using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;

using ErrorOr;

namespace BeatEcoprove.Application.Shared.Interfaces.Services;

public interface IClosetService
{
    Task<ClothResult> AddClothToCloset(Profile profile, Cloth cloth, string brandName, string colorHex, Stream clothAvatar, CancellationToken cancellationToken = default);
    Task<ErrorOr<Bucket>> AddBucketToCloset(Profile profile, Bucket bucket, List<ClothId> clothToAdd, CancellationToken cancellationToken = default);
    Task<ErrorOr<Bucket>> AddClothToBucket(Profile profile, Bucket bucket, List<ClothId> cloths, CancellationToken cancellationToken = default);
    Task<ErrorOr<Bucket>> RemoveClothFromBucket(Profile profile, Bucket bucket, List<ClothId> clothToRemove, CancellationToken cancellationToken);
    Task<ErrorOr<Cloth>> GetCloth(Profile profile, ClothId clothId, CancellationToken cancellationToken = default);
    Task<ErrorOr<ClothResult>> GetClothResult(Profile profile, ClothId clothId, bool withDeleted = false, CancellationToken cancellationToken = default);
    Task<ErrorOr<BucketResult>> GetBucketResult(Profile profile, Bucket bucket, CancellationToken cancellationToken = default);
    ErrorOr<ClothType> GetClothType(string type);
    ErrorOr<ClothSize> GetClothSize(string size);
    Task<ErrorOr<ClothResult>> RemoveClothFromCloset(Profile profile, ClothId clothId, CancellationToken cancellationToken);
    Task<ErrorOr<BucketResult>> RemoveBucketFromCloset(Profile profile, BucketId bucketId, CancellationToken cancellationToken);
}