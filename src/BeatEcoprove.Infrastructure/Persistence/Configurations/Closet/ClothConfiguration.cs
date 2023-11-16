using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeatEcoprove.Infrastructure.Persistence.Configurations.Closet;

public class ClothConfiguration : IEntityTypeConfiguration<Domain.ClosetAggregator.Cloth>
{
    private const string ClothTable = "cloths";

    public void Configure(EntityTypeBuilder<Domain.ClosetAggregator.Cloth> builder)
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

        builder.Property(c => c.Name)
            .HasColumnName("name")
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(c => c.Type)
            .HasColumnName("type")
            .IsRequired();

        builder.Property(c => c.Size)
            .HasColumnName("size")
            .IsRequired();

        builder.Property(c => c.Brand)
            .HasColumnName("brand")
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(c => c.Color)
            .HasColumnName("color")
            .HasMaxLength(50)
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