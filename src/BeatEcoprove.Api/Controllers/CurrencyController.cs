using BeatEcoprove.Api.Extensions;
using BeatEcoprove.Application.Currency.Queries.ConvertCurrency;
using BeatEcoprove.Application.Shared.Multilanguage;
using BeatEcoprove.Contracts.Currency;

using MapsterMapper;

using MediatR;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BeatEcoprove.Api.Controllers;

[Authorize]
[Route("extension/concurrency")]
public class CurrencyController : ApiController
{
    private readonly ISender _sender;
    private readonly IMapper _mapper;

    public CurrencyController(
        ISender sender,
        IMapper mapper,
        ILanguageCulture languageCulture) : base(languageCulture)
    {
        _sender = sender;
        _mapper = mapper;
    }

    [HttpGet("convert")]
    public async Task<ActionResult<Conversionresult>> GetAllCurrencies(
        [FromRoute] Guid profileId,
        [FromQuery] int? ecoCoins,
        [FromQuery] int? sustainabilityPoints
        )
    {
        var authId = HttpContext.User.GetUserId();

        var getAllCurrenciesResult =
            await _sender.Send(
                new ConvertCurrencyQuery(
                    authId,
                    profileId,
                    ecoCoins,
                    sustainabilityPoints
                ));

        return getAllCurrenciesResult.Match(
            currencyResponse => Ok(_mapper.Map<Conversionresult>(currencyResponse)),
            Problem<Conversionresult>
        );
    }
}