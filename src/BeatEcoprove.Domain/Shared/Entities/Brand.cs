using BeatEcoprove.Domain.Shared.Models;
using BeatEcoprove.Domain.Shared.ValueObjects;
using ErrorOr;
using BeatEcoprove.Domain.Shared.Errors;

namespace BeatEcoprove.Domain.Shared.Entities;

public class Brand : Entity<BrandId>
{
    private Brand() { }
    
    private Brand(string name, string brandAvatar)
    {
        Name = name;
        BrandAvatar = brandAvatar;
    }

    public string Name { get; private set; }
    public string BrandAvatar { get; private set; }
    
    public static ErrorOr<Brand> Create(string name, string brandAvatar)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            return Errors.Errors.Brand.MustProvideBrandName;
        }

        if (string.IsNullOrWhiteSpace(brandAvatar))
        {
            return Errors.Errors.Brand.MustProvideBrandAvatar;
        }
        
        return new Brand(
            name,
            brandAvatar
        );
    }
}