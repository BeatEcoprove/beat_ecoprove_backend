using BeatEcoprove.Contracts.Colors;
using BeatEcoprove.Domain.Shared.Entities;
using Mapster;

namespace BeatEcoprove.Api.Mappers;

public class ExtensionMappingConfiguration : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<Color, ColorResponse>();
    }
}