using BeatEcoprove.Domain.AdvertisementAggregator;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;

using ErrorOr;

namespace BeatEcoprove.Application.Shared.Interfaces.Services;

public interface IAdvertisementService
{
    Task<ErrorOr<Advertisement>> CreateAdd(
        Advertisement advertisement,
        Profile profile,
        Stream picture,
        CancellationToken cancellationToken = default);
}