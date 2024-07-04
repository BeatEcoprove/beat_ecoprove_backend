using BeatEcoprove.Application.Shared.Extensions;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Providers;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Application.Shared.Interfaces.Services.Common;
using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.ProfileAggregator.Enumerators;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;
using BeatEcoprove.Domain.StoreAggregator;
using BeatEcoprove.Domain.StoreAggregator.Daos;
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
    private readonly IAuthRepository _authRepository;
    private readonly IClosetService _closetService;

    public StoreService(
        IStoreRepository storeRepository,
        IFileStorageProvider fileStorageProvider,
        IProfileRepository profileRepository,
        IMaintenanceServiceRepository maintenanceServiceRepository,
        IPasswordGenerator passwordGenerator,
        IAccountService accountService, 
        IAuthRepository authRepository, IClosetService closetService)
    {
        _storeRepository = storeRepository;
        _fileStorageProvider = fileStorageProvider;
        _profileRepository = profileRepository;
        _maintenanceServiceRepository = maintenanceServiceRepository;
        _passwordGenerator = passwordGenerator;
        _accountService = accountService;
        _authRepository = authRepository;
        _closetService = closetService;
    }

    public async Task<List<Order>> GetAllStores(ProfileId owner, GetAllStoreInput input,
        CancellationToken cancellationToken = default)
    {
        var stores = await _storeRepository.GetAllStoresAsync(
            owner,
            input.Search,
            input.Services,
            input.Colors,
            input.Brands,
            input.PageSize,
            input.Page,
            cancellationToken
        );

        return stores;
    }

    public async Task<ErrorOr<List<Store>>> GetOwningStoreAsync(
        Profile profile,
        GetOwningStoreInput input,
        CancellationToken cancellationToken = default)
    {
        bool isEmployee = profile.Type.Equals(UserType.Employee);

        var stores = await _storeRepository.GetOwningStoreAsync(
            profile.Id,
            isEmployee,
            input.Search,
            input.Page,
            input.PageSize,
            cancellationToken);

        return stores;
    }

    public async Task<ErrorOr<Store>> GetStoreAsync(
        StoreId id, 
        Profile profile,
        CancellationToken cancellationToken = default)
    {
        var isEmployee = profile.Type.Equals(UserType.Employee);
        
        if (!await _storeRepository.HasAccessToStore(id, profile, isEmployee, cancellationToken))
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

    public async Task<ErrorOr<Store>> CreateStoreAsync(
        Store store,
        Profile profile,
        Stream picture,
        CancellationToken cancellationToken)
    {
        if (!profile.Type.Equals(UserType.Organization))
        {
            return Errors.Store.CantCreateStore;
        }

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

    public async Task<ErrorOr<Store>> DeleteStoreAsync(Store store, Profile profile,
        CancellationToken cancellationToken = default)
    {
        if (profile.Type.Equals(UserType.Employee))
        {
            return Errors.Store.DontHaveAccessToStore;
        }

        var deleted = await _storeRepository.DeleteStoreAsync(store, cancellationToken);

        if (deleted)
        {
            return Errors.Store.StoreNotFound;
        }

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

    public async Task<ErrorOr<Order>> CompleteOrderAsync(
        Store store, 
        OrderId orderId, 
        ProfileId ownerId, 
        CancellationToken cancellationToken = default)
    {
        var order = store
            .Orders
            .Where(order => order is OrderCloth)
            .FirstOrDefault(order => order.Id == orderId) as OrderCloth;

        if (order is null)
        {
            return Errors.Order.NotFound;
        }

        if (order.Status == OrderStatus.Completed)
        {
            return Errors.Order.IsAlreadyCompleted;
        }
        
        var owner = await _profileRepository.GetByIdAsync(ownerId, cancellationToken);

        if (owner is null)
        {
            return Errors.Profile.NotFound;
        }

        var cloth = await _closetService.GetCloth(
            owner,
            order.Cloth,
            cancellationToken);

        if (cloth.IsError)
        {
            return Errors.Cloth.CannotAccessBucket;
        }

        order.Complete();

        return order;
    }

    public async Task<ErrorOr<(Worker, Password)>> RegisterWorkerAsync(
        Store store,
        Profile profile,
        AddWorkerInput input,
        CancellationToken cancellationToken = default)
    {
        var isEmployee = profile.Type.Equals(UserType.Employee);

        if (isEmployee)
        {
            var foundWorker = await _storeRepository.GetWorkerByProfileAsync(profile.Id, cancellationToken);

            if (foundWorker is null)
            {
                return Errors.Worker.NotFound;
            }

            if (foundWorker.Role != WorkerType.Manager)
            {
                return Errors.Store.DontHaveAccessToStore;
            }
        }

        if (input.Name.IsNullOrEmpty())
        {
            return Errors.Worker.NotAllowedName;
        }

        if (!await _storeRepository.HasAccessToStore(store.Id, profile, isEmployee, cancellationToken))
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

    public async Task<ErrorOr<Worker>> RemoveWorkerAsync(Store store, Profile profile, WorkerId workerId, CancellationToken cancellationToken = default)
    {
        var isEmployee = profile.Type.Equals(UserType.Employee);

        if (isEmployee)
        {
            var foundWorker = await _storeRepository.GetWorkerByProfileAsync(profile.Id, cancellationToken);

            if (foundWorker is null)
            {
                return Errors.Worker.NotFound;
            }

            if (foundWorker.Role != WorkerType.Manager)
            {
                return Errors.Store.DontHaveAccessToStore;
            }
        }        
        
        var worker = await _storeRepository.GetWorkerAsync(workerId, cancellationToken);

        if (worker is null)
        {
            return Errors.Worker.NotFound;
        }

        var workerProfile = await _profileRepository.GetByIdAsync(worker.Profile, cancellationToken);

        if (workerProfile is null)
        {
            return Errors.Profile.NotFound;
        }

        await _authRepository.RemoveAuthProfileAsync(workerProfile, cancellationToken);
        await _storeRepository.RemoveWorkerAsync(worker.Id, cancellationToken);

        return worker;
    }

    public async Task<ErrorOr<Worker>> SwitchPermission(Store store, Profile profile, SwitchPermissionInput input,
        CancellationToken cancellationToken = default)
    {
        var isEmployee = profile.Type.Equals(UserType.Employee);
        
        if (!await _storeRepository.HasAccessToStore(store.Id, profile, isEmployee, cancellationToken))
        {
            return Errors.Store.DontHaveAccessToStore;
        }

        var worker = await _storeRepository.GetWorkerAsync(input.WorkerId, cancellationToken);

        if (worker is null)
        {
            return Errors.Worker.NotFound;
        }

        var shouldUpgrade = store.SwitchWorkerPermission(
            worker,
            input.WorkerType
        );

        if (shouldUpgrade.IsError)
        {
            return shouldUpgrade.Errors;
        }

        return shouldUpgrade;
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