using BeatEcoprove.Application.Closet.Common;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Providers;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.ClosetAggregator;
using BeatEcoprove.Domain.ClosetAggregator.Enumerators;
using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
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
    private readonly IProfileRepository _profileRepository;

    public ClosetService(
        IFileStorageProvider fileStorageProvider, 
        IClothRepository clothRepository, 
        IBucketRepository bucketRepository, 
        IProfileRepository profileRepository)
    {
        _fileStorageProvider = fileStorageProvider;
        _clothRepository = clothRepository;
        _bucketRepository = bucketRepository;
        _profileRepository = profileRepository;
    }

    public async Task<ClothResult> AddClothToCloset(
        Profile profile, 
        Cloth cloth,
        string brandName,
        string colorHex, 
        Stream clothAvatar, 
        CancellationToken cancellationToken = default)
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
            brandName,
            colorHex,
            cloth.EcoScore,
            cloth.State.ToString(),
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
        
        if (await _bucketRepository.AreClothAlreadyOnBucket(clothToAdd, cancellationToken))
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

    public async Task<ErrorOr<Bucket>> AddClothToBucket(Profile profile, Bucket bucket, List<ClothId> cloths, CancellationToken cancellationToken = default)
    {
        if (!await _clothRepository.ClothExists(cloths, cancellationToken))
        {
            return Errors.Bucket.InvalidClothToAdd;
        }
        
        if (!await _profileRepository.CanProfileAccessBucket(profile.Id, bucket.Id, cancellationToken))
        {
            return Errors.Bucket.CannotAccessBucket;
        }
        
        if (await _bucketRepository.AreClothAlreadyOnBucket(cloths, cancellationToken))
        {
            return Errors.Bucket.CanAddClothToBucket;
        }
        
        var shouldAddAllCloth = bucket.AddCloths(cloths);

        if (shouldAddAllCloth.IsError)
        {
            return shouldAddAllCloth.Errors;
        }
        
        return bucket;
    }

    public async Task<ErrorOr<Bucket>> RemoveClothFromBucket(Profile profile, Bucket bucket, List<ClothId> clothToRemove, CancellationToken cancellationToken)
    {
        if (!await _clothRepository.ClothExists(clothToRemove, cancellationToken))
        {
            return Errors.Bucket.InvalidClothToAdd;
        }
        
        if (!await _profileRepository.CanProfileAccessBucket(profile.Id, bucket.Id, cancellationToken))
        {
            return Errors.Bucket.CannotAccessBucket;
        }
        
        if (!await _bucketRepository.AreClothAlreadyOnBucket(clothToRemove, cancellationToken))
        {
            return Errors.Bucket.CannotRemoveCloth;
        }
        
        var shouldRemoveCloth = bucket.RemoveCloths(clothToRemove);

        if (shouldRemoveCloth.IsError)
        {
            return shouldRemoveCloth.Errors;
        }
        
        return bucket;
    }

    public async Task<ErrorOr<Cloth>> GetCloth(Profile profile, ClothId clothId, CancellationToken cancellationToken = default)
    {
        if (!await _profileRepository.CanProfileAccessCloth(profile.Id, clothId, cancellationToken))
        {
            return Errors.Cloth.CannotAccessBucket;
        }
        
        var cloth = await _clothRepository.GetByIdAsync(clothId, cancellationToken);

        if (cloth is null)
        {
            return Errors.Cloth.InvalidClothName;
        }

        return cloth;
    }
    
    public async Task<ErrorOr<ClothResult>> GetClothResult(Profile profile, ClothId clothId, CancellationToken cancellationToken = default)
    {
        if (!await _profileRepository.CanProfileAccessCloth(profile.Id, clothId, cancellationToken))
        {
            return Errors.Cloth.CannotAccessBucket;
        }
        
        var cloth = await _clothRepository.GetClothDaoByIdAsync(clothId, cancellationToken);

        if (cloth is null)
        {
            return Errors.Cloth.InvalidClothName;
        }

        return cloth.Adapt<ClothResult>();
    }

    public async Task<BucketResult> GetBucketResult(Bucket bucket, CancellationToken cancellationToken = default)
    {
        var cloths = await
            _bucketRepository.GetClothsAsync(bucket.Id, cancellationToken);
        
        return new BucketResult(
            bucket,
            cloths.Adapt<List<ClothResult>>());
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