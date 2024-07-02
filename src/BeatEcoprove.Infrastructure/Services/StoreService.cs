using BeatEcoprove.Application.Shared.Extensions;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Providers;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Application.Shared.Interfaces.Services.Common;
using BeatEcoprove.Domain.AuthAggregator;
using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;
using BeatEcoprove.Domain.StoreAggregator;
using BeatEcoprove.Domain.StoreAggregator.Entities;
using BeatEcoprove.Domain.StoreAggregator.Enumerators;
using BeatEcoprove.Domain.StoreAggregator.ValueObjects;

using ErrorOr;

using Microsoft.IdentityModel.Tokens;

namespace BeatEcoprove.Infrastructure.Services;

public class StoreService : IStoreService
{
    private readonly IStoreRepository _storeRepository;
    private readonly IFileStorageProvider _fileStorageProvider;
    private readonly IProfileRepository _profileRepository;
    private readonly IMaintenanceServiceRepository _maintenanceServiceRepository;
    private readonly IPasswordGenerator _passwordGenerator;
    private readonly IAccountService _accountService;

    public StoreService(
        IStoreRepository storeRepository, 
        IFileStorageProvider fileStorageProvider, 
        IProfileRepository profileRepository, 
        IMaintenanceServiceRepository maintenanceServiceRepository,
        IPasswordGenerator passwordGenerator, 
        IAccountService accountService)
    {
        _storeRepository = storeRepository;
        _fileStorageProvider = fileStorageProvider;
        _profileRepository = profileRepository;
        _maintenanceServiceRepository = maintenanceServiceRepository;
        _passwordGenerator = passwordGenerator;
        _accountService = accountService;
    }

    public async Task<List<Order>> GetAllStores(ProfileId owner, GetAllStoreInput input, CancellationToken cancellationToken = default)
    {
        var stores = await _storeRepository.GetAllStoresAsync(
            owner,
            input.Search,
            input.Services,
            input.Colors,
            input.Brands,
            input.OrderBy,
            input.PageSize,
            input.Page, 
            cancellationToken
        );

        return stores;
    }

    public async Task<ErrorOr<Store>> GetStoreAsync(StoreId id, Profile profile, CancellationToken cancellationToken = default)
    {
        if (!await _storeRepository.HasAccessToStore(id, profile, cancellationToken))
        {
            return Errors.Store.DontHaveAccessToStore;
        }

        var store = await _storeRepository.GetByIdAsync(id, cancellationToken);

        if (store is null)
        {
            return Errors.Store.StoreNotFound;
        }

        return store;
    }

    public async Task<ErrorOr<Store>> CreateStoreAsync(Store store, Stream picture, CancellationToken cancellationToken)
    {
        if (await _storeRepository.ExistsAnyStoreWithName(store.Name, cancellationToken))
        {
            return Errors.Store.StoreAlreadyExistsName;
        }
        
        var avatarUrl = 
             await _fileStorageProvider
                .UploadFileAsync(
                    Buckets.ProfileBucket,
                    ((Guid)store.Id).ToString(),
                    picture,
                    cancellationToken);
                
        store.SetPictureUrl(avatarUrl);

        await _storeRepository.AddAsync(store, cancellationToken);
        return store;
    }

    public async Task<ErrorOr<Order>> RegisterOrderAsync(
        Store store, 
        ProfileId owner, 
        ClothId clothId,
        CancellationToken cancellationToken = default)
    {
        if (!await _profileRepository.CanProfileAccessCloth(owner, clothId, cancellationToken))
        {
            return Errors.Profile.CannotFindCloth;
        }

        var maintenance = await _maintenanceServiceRepository.GetMaintenanceServiceByName(
            "Lavar", 
            cancellationToken);

        if (maintenance is null)
        {
            return Errors.MaintenanceService.NotFound;
        }

        var order = store.RegisterOrderCloth(
            owner,
            clothId,
            new() { maintenance.Id }
        );

        return order;
    }

    public async Task<ErrorOr<(Worker, Password)>> RegisterWorkerAsync(
        Store store, 
        Profile profile, 
        AddWorkerInput input,
        CancellationToken cancellationToken = default)
    {
        if (input.Name.IsNullOrEmpty())
        {
            return Errors.Worker.NotAllowedName;
        }

        if (!await _storeRepository.HasAccessToStore(store.Id, profile, cancellationToken))
        {
            return Errors.Store.DontHaveAccessToStore;
        }
        
        var password = _passwordGenerator.GeneratePassword(6, 16);
        var userName = UserName.Create(input.Name);

        if (userName.IsError)
        {
            return userName.Errors;
        }
        
        var employee = Employee.Create(
            userName.Value,
            profile.Phone.Clone()
        );

        var account = await _accountService.CreateAccount(
            input.Email,
            password,
            employee,
            Stream.Null,
            cancellationToken
        );

        if (account.IsError)
        {
            return account.Errors;
        }

        var worker = store.AddWorker(
            employee,
            input.Type
        );

        return (worker, password);
    }

    public ErrorOr<WorkerType> GetWorkerType(string permission)
    {
        if (permission.CanConvertToEnum(out WorkerType result))
        {
            return result;
        }

        return Errors.Worker.InvalidPermission;
    }
}