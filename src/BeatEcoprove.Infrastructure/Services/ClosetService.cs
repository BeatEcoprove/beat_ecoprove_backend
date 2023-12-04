using BeatEcoprove.Application.Closet.Common;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Application.Shared.Interfaces.Persistence;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Providers;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.ClosetAggregator;
using BeatEcoprove.Domain.ClosetAggregator.Enumerators;
using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.ProfileAggregator.Enumerators;
using BeatEcoprove.Domain.Shared.Errors;
using BeatEcoprove.Infrastructure.Extensions;
using ErrorOr;
using Mapster;

namespace BeatEcoprove.Infrastructure.Services;

public class ClosetService : IClosetService
{
    private readonly IFileStorageProvider _fileStorageProvider;
    private readonly IClothRepository _clothRepository;
    private readonly IBucketRepository _bucketRepository;

    public ClosetService(
        IFileStorageProvider fileStorageProvider, 
        IClothRepository clothRepository, 
        IBucketRepository bucketRepository)
    {
        _fileStorageProvider = fileStorageProvider;
        _clothRepository = clothRepository;
        _bucketRepository = bucketRepository;
    }

    public async Task<ClothResult> AddClothToCloset(Profile profile, Cloth cloth, string colorHex, Stream clothAvatar, CancellationToken cancellationToken = default)
    {
        var clothPicture = profile.Id.Value + "-" + cloth.Id.Value;
        var clothPictureUrl = await _fileStorageProvider
            .UploadFileAsync(Buckets.ClothBucket, clothPicture, clothAvatar, cancellationToken);

        cloth.SetClothPicture(clothPictureUrl);

        profile.AddCloth(cloth);

        await _clothRepository.AddAsync(cloth, cancellationToken);

        return new(
            cloth.Id,
            cloth.Name,
            cloth.Type.ToString(),
            cloth.Size.ToString(),
            cloth.Brand,
            colorHex,
            cloth.EcoScore,
            cloth.ClothAvatar
        );
    }

    public async Task<ErrorOr<Bucket>> AddBucketToCloset(
        Profile profile, 
        Bucket bucket,
        List<ClothId> clothToAdd,
        CancellationToken cancellationToken = default)
    {
        if (await _bucketRepository.IsBucketNameAlreadyUsed(profile.Id, bucket.Id, bucket.Name, cancellationToken))
        {
            return Errors.Bucket.BucketNameAlreadyUsed;
        }
        
        if (!await _clothRepository.ClothExists(clothToAdd, cancellationToken))
        {
            return Errors.Bucket.InvalidClothToAdd;
        }
        
        if (!await _bucketRepository.CanAddClothsAsync(clothToAdd, cancellationToken))
        {
            return Errors.Bucket.CanAddClothToBucket;
        }

        var shouldAddClothToBucket = bucket.AddCloths(clothToAdd);

        if (shouldAddClothToBucket.IsError)
        {
            return shouldAddClothToBucket.Errors;
        }
        
        profile.AddBucket(bucket);
        await _bucketRepository.AddAsync(bucket, cancellationToken);

        return bucket;
    }
    
    public ErrorOr<ClothType> GetClothType(string type)
    {
        if (type.CanConvertToEnum(out ClothType result))
        {
            return result;
        }

        return Errors.Cloth.InvalidClothType;
    }
    
    public ErrorOr<ClothSize> GetClothSize(string size)
    {
        if (size.CanConvertToEnum(out ClothSize result))
        {
            return result;
        }

        return Errors.Cloth.InvalidClothSize;
    }
}