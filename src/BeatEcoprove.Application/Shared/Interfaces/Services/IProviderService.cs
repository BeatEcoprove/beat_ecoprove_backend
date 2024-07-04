using BeatEcoprove.Application.Shared.Interfaces.Services.Common;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;

using ErrorOr;

namespace BeatEcoprove.Application.Shared.Interfaces.Services;

public interface IProviderService
{
    Task<ErrorOr<List<Organization>>> GetAllProvidersAsync(
        GetAllProviderInput input,
        CancellationToken cancellationToken = default
    );
}