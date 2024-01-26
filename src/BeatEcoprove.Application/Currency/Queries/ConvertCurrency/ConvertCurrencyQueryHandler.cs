using BeatEcoprove.Application.Currency.Common;
using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;
using ErrorOr;

namespace BeatEcoprove.Application.Currency.Queries.ConvertCurrency;

internal sealed class ConvertCurrencyQueryHandler : IQueryHandler<ConvertCurrencyQuery, ErrorOr<ConversionResult>>
{
    private readonly IProfileManager _profileManager;

    public ConvertCurrencyQueryHandler(IProfileManager profileManager)
    {
        _profileManager = profileManager;
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

        var result = (ErrorOr<bool>)(request.Symbol switch
        {
            "ec" => profile.Value.ConvertEcoCoins(request.EcoCoins, request.SustainabilityPoints),
            "sp" => profile.Value.ConvertSustainabilityPoints(request.SustainabilityPoints, request.EcoCoins),
            _ => Errors.Concurrency.SymbolNotDefined
        });
        
        if (result.IsError)
        {
            return result.Errors;
        }

        return new ConversionResult(
            profile.Value.EcoCoins,
            profile.Value.SustainabilityPoints
        );
    }
}