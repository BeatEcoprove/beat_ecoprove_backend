using BeatEcoprove.Application.Currency.Common;
using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Helpers;
using ErrorOr;

namespace BeatEcoprove.Application.Currency.Queries.ConvertCurrency;

public record ConvertCurrencyQuery
(
    Guid AuthId,
    Guid ProfileId,
    int EcoCoins,
    int SustainabilityPoints,
    string Symbol
) : IQuery<ErrorOr<ConversionResult>>, IAuthorization;