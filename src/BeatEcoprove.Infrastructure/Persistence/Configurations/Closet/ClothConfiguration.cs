using BeatEcoprove.Domain.ClosetAggregator;
using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Entities;
using BeatEcoprove.Domain.Shared.ValueObjects;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeatEcoprove.Infrastructure.Persistence.Configurations.Closet;

public class ClothConfiguration : IEntityTypeConfiguration<Cloth>
{
    private const string ClothTable = "cloths";

    public void Configure(EntityTypeBuilder<Cloth> builder)
    {
        ConfigureClothEntity(builder);

        builder.HasMany(cloth => cloth.Activities)
            .WithOne()
            .HasForeignKey(activity => activity.ClothId);
    }

    private static void ConfigureClothEntity(EntityTypeBuilder<Cloth> builder)
    {
        builder.ToTable(ClothTable);
        builder.HasKey(c => c.Id);

        builder.Property(c => c.Id)
            .HasColumnName("id")
            .ValueGeneratedNever()
            .HasConversion(
                id => id.Value,
                value => ClothId.Create(value))
            .IsRequired();

        builder.Property(cloth => cloth.DeletedAt)
            .HasColumnName("deleted_at");

        builder.Property(c => c.Name)
            .HasColumnName("name")
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(c => c.Type)
            .HasColumnName("type")
            .IsRequired();

        builder.Property(c => c.State)
            .HasColumnName("state")
            .IsRequired();

        builder.Property(c => c.Size)
            .HasColumnName("size")
            .IsRequired();

        builder
            .HasOne<Brand>()
            .WithMany()
            .HasForeignKey(c => c.Brand);

        builder.Property(c => c.Brand)
            .HasColumnName("brand")
            .HasConversion(
                id => id.Value,
                value => BrandId.Create(value)
            )
            .IsRequired();

        builder
            .HasOne<Color>()
            .WithMany()
            .HasForeignKey(c => c.Color);

        builder.Property(c => c.Color)
            .HasColumnName("color")
            .HasConversion(
                id => id.Value,
                value => ColorId.Create(value)
            )
            .IsRequired();

        builder.Property(c => c.EcoScore)
            .HasColumnName("eco_score")
            .IsRequired();

        builder.Property(c => c.ClothAvatar)
            .HasColumnName("cloth_avatar")
            .HasMaxLength(256)
            .IsRequired();
    }
}