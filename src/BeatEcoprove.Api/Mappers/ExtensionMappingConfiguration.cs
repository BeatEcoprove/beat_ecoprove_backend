using BeatEcoprove.Contracts.Brands;
using BeatEcoprove.Contracts.Colors;
using BeatEcoprove.Domain.Shared.Entities;

using Mapster;

namespace BeatEcoprove.Api.Mappers;

public class ExtensionMappingConfiguration : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<Color, ColorResult>();
        config.NewConfig<List<Color>, ColorResponse>()
            .MapWith(src =>
                new ColorResponse(src.Select(color => color.Adapt<ColorResult>()).ToList()));

        config.NewConfig<Brand, BrandResult>();
        config.NewConfig<List<Brand>, BrandResponse>()
            .MapWith(src =>
                new BrandResponse(src.Select(brand => brand.Adapt<BrandResult>()).ToList()));
    }
}