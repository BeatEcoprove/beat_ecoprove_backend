using BeatEcoprove.Domain.Shared.Entities;
using BeatEcoprove.Domain.Shared.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeatEcoprove.Infrastructure.Persistence.Configurations.Extensions;

public class BrandConfiguration : IEntityTypeConfiguration<Brand>
{
    private const string BrandTableName = "brands";
    
    public void Configure(EntityTypeBuilder<Brand> builder)
    {
        builder.ToTable(BrandTableName);
        builder.HasKey(brand => brand.Id);

        builder.Property(brand => brand.Id)
            .HasColumnName("id")
            .ValueGeneratedNever()
            .HasConversion(
                id => id.Value,
                id => BrandId.Create(id)
            );

        builder.Property(brand => brand.Name)
            .HasColumnName("name")
            .HasMaxLength(30)
            .IsRequired();

        builder.Property(brand => brand.BrandAvatar)
            .HasColumnName("brand_avatar")
            .HasMaxLength(256)
            .IsRequired();
    }
}