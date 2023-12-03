using BeatEcoprove.Application.Closet.Common;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Application.Shared.Interfaces.Persistence;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Providers;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.ClosetAggregator;
using BeatEcoprove.Domain.ClosetAggregator.Enumerators;
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
    private readonly IUnitOfWork _unitOfWork;

    public ClosetService(
        IFileStorageProvider fileStorageProvider, 
        IClothRepository clothRepository, 
        IBucketRepository bucketRepository, 
        IUnitOfWork unitOfWork)
    {
        _fileStorageProvider = fileStorageProvider;
        _clothRepository = clothRepository;
        _bucketRepository = bucketRepository;
        _unitOfWork = unitOfWork;
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

    public async Task<BucketResult> AddBucketToCloset(Profile profile, Bucket bucket, CancellationToken cancellationToken = default)
    {
        profile.AddBucket(bucket);
        await _bucketRepository.AddAsync(bucket, cancellationToken);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        
        var cloths = await
            _bucketRepository.GetClothsAsync(bucket.Id, cancellationToken);
        
        return new BucketResult(
            bucket,
            cloths.Adapt<List<ClothResult>>()
            );
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