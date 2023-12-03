using BeatEcoprove.Application.Closet.Common;
using BeatEcoprove.Domain.ClosetAggregator;
using BeatEcoprove.Domain.ClosetAggregator.Enumerators;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.ProfileAggregator.Enumerators;
using ErrorOr;

namespace BeatEcoprove.Application.Shared.Interfaces.Services;

public interface IClosetService
{
    Task<ClothResult> AddClothToCloset(Profile profile, Cloth cloth, string colorHex, Stream clothAvatar, CancellationToken cancellationToken = default);
    Task<BucketResult> AddBucketToCloset(Profile profile, Bucket bucket, CancellationToken cancellationToken = default);
    ErrorOr<ClothType> GetClothType(string type);
    ErrorOr<ClothSize> GetClothSize(string size);
}