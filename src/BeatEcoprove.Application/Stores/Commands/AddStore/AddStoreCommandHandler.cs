using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Interfaces.Persistence;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.StoreAggregator;

using ErrorOr;

using NetTopologySuite.Geometries;

namespace BeatEcoprove.Application.Stores.Commands.AddStore;

internal sealed class AddStoreCommandHandler : ICommandHandler<AddStoreCommand, ErrorOr<Store>>
{
    private readonly IProfileManager _profileManager;
    private readonly IStoreService _storeService;
    private readonly IStoreRepository _storeRepository;
    private readonly IUnitOfWork _unitOfWork;

    public AddStoreCommandHandler(
        IProfileManager profileManager,
        IStoreService storeService, 
        IStoreRepository storeRepository, 
        IUnitOfWork unitOfWork)
    {
        _profileManager = profileManager;
        _storeService = storeService;
        _storeRepository = storeRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<ErrorOr<Store>> Handle(AddStoreCommand request, CancellationToken cancellationToken)
    {
        var authId = AuthId.Create(request.AuthId);
        var profileId = ProfileId.Create(request.ProfileId);
        var postalCode = PostalCode.Create(request.PostalCode);
        
        if (postalCode.IsError)
        {
            return postalCode.Errors;
        }
        
        var address = Address.Create(
            request.Street,
            request.Port,
            request.Locality,
            postalCode.Value
        );

        if (address.IsError)
        {
            return address.Errors;
        }

        var profile = await _profileManager.GetProfileAsync(authId, profileId, cancellationToken);

        if (profile.IsError)
        {
            return profile.Errors;
        }
        
        var store = Store.Create(
            profile.Value.Id,
            request.Name,
            address.Value,
            new Point(new Coordinate(request.Lat, request.Lon))
        );

        var storeResult = await _storeService.CreateStoreAsync(
            store,
            profile.Value,
            request.Picture,
            cancellationToken
        );

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return storeResult;
    }
}