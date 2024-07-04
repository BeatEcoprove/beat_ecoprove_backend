using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Application.Shared.Interfaces.Services.Common;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;

using ErrorOr;

namespace BeatEcoprove.Infrastructure.Services;

public class ProviderService : IProviderService
{
    private readonly IProfileRepository _profileRepository;

    public ProviderService(
        IProfileRepository profileRepository)
    {
        _profileRepository = profileRepository;
    }

    public async Task<ErrorOr<List<Organization>>> GetAllProvidersAsync(GetAllProviderInput input, CancellationToken cancellationToken = default)
    {
        var organizations = await _profileRepository.GetAllOrganizationsAsync(
            input.Search,
            input.Page,
            input.PageSize,
            cancellationToken
        );

        return organizations;
    }
}