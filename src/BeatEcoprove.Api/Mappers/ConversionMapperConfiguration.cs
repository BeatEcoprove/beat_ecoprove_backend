using BeatEcoprove.Application.Currency.Common;
using BeatEcoprove.Contracts.Currency;

using Mapster;

namespace BeatEcoprove.Api.Mappers;

public class ConversionMapperConfiguration : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<ConversionResult, Conversionresult>();
    }
}