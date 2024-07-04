using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Application.Shared.Interfaces.Services.Common;
using BeatEcoprove.Domain.ProfileAggregator.DAOS;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;

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

    public async Task<ErrorOr<ProviderDao>> GetProviderByIdAsync(ProfileId providerId, CancellationToken cancellationToken = default)
    {
        var organization = await _profileRepository.GetOrganizationAsync(
            providerId,
            cancellationToken);

        if (organization is null)
        {
            return Errors.Provider.NotFound;
        }

        return organization;
    }
}