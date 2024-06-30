using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.StoreAggregator;

using ErrorOr;

namespace BeatEcoprove.Application.Shared.Interfaces.Services;

public interface IStoreService
{
    Task<ErrorOr<Store>> CreateStoreAsync(
        Store store,
        Stream avatarPicture,
        CancellationToken cancellationToken);
}