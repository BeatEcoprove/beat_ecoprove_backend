using BeatEcoprove.Application.Currency.Common;
using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Interfaces.Persistence;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Extensions;

using ErrorOr;

namespace BeatEcoprove.Application.Currency.Queries.ConvertCurrency;

internal sealed class ConvertCurrencyQueryHandler : IQueryHandler<ConvertCurrencyQuery, ErrorOr<ConversionResult>>
{
    private readonly IProfileManager _profileManager;
    private readonly IUnitOfWork _unitOfWork;

    public ConvertCurrencyQueryHandler(
        IProfileManager profileManager,
        IUnitOfWork unitOfWork)
    {
        _profileManager = profileManager;
        _unitOfWork = unitOfWork;
    }

    public async Task<ErrorOr<ConversionResult>> Handle(ConvertCurrencyQuery request, CancellationToken cancellationToken)
    {
        var authId = AuthId.Create(request.AuthId);
        var profileId = ProfileId.Create(request.ProfileId);

        var profile = await _profileManager.GetProfileAsync(authId, profileId, cancellationToken);

        if (profile.IsError)
        {
            return profile.Errors;
        }

        ErrorOr<bool> validator = false;
        if (request.EcoCoins is not null)
        {
            validator = validator.AddValidate(profile.Value.ConvertToSustainabilityPoints(request.EcoCoins.Value));
        }

        if (request.SustainabilityPoints is not null)
        {
            validator = validator.AddValidate(profile.Value.ConvertToEcoCoins(request.SustainabilityPoints.Value));
        }

        if (validator.IsError)
        {
            return validator.Errors;
        }

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return new ConversionResult(
            profile.Value.EcoCoins,
            profile.Value.SustainabilityPoints
        );
    }
}