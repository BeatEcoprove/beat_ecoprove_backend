using BeatEcoprove.Domain.Shared.Models;
using BeatEcoprove.Domain.Shared.ValueObjects;
using ErrorOr;

namespace BeatEcoprove.Domain.Shared.Entities;

public class Brand : Entity<BrandId>
{
    private Brand() { }
    
    private Brand(BrandId id, string name, string brandAvatar)
    {
        Id = id;
        Name = name;
        BrandAvatar = brandAvatar;
    }
    
    private Brand(BrandId id, string name)
    {
        Id = id;
        Name = name;
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
            BrandId.CreateUnique(),
            name,
            brandAvatar
        );
    }
    
    public static ErrorOr<Brand> FromName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            return Errors.Errors.Brand.MustProvideBrandName;
        }
        
        return new Brand(
            BrandId.CreateUnique(),
            name
        );
    }
}