using BeatEcoprove.Application.Closet.Common;
using BeatEcoprove.Domain.ClosetAggregator;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;

namespace BeatEcoprove.Application.Shared.Interfaces.Services;

public interface IClosetService
{
    Task<ClothResult> AddClothToCloset(Profile profile, Cloth cloth, string colorHex, Stream clothAvatar, CancellationToken cancellationToken = default);
    
    Task<BucketResult> AddBucketToCloset(Profile profile, Bucket bucket, CancellationToken cancellationToken = default);
}