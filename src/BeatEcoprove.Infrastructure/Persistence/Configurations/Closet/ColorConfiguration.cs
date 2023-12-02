using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Entities;
using BeatEcoprove.Domain.Shared.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeatEcoprove.Infrastructure.Persistence.Configurations.Closet;

public class ColorConfiguration : IEntityTypeConfiguration<Color>
{
    public void Configure(EntityTypeBuilder<Color> builder)
    {
        builder.ToTable("colors");
        builder.HasKey(color => color.Id);

        builder.Property(color => color.Id)
            .HasColumnName("id")
            .ValueGeneratedNever()
            .HasConversion(
                id => id.Value,
                id => ColorId.Create(id)
            );

        builder.Property(color => color.Hex)
            .HasColumnName("hex")
            .HasMaxLength(8)
            .IsRequired();

        builder.Property(color => color.Name)
            .HasColumnName("name")
            .HasMaxLength(256)
            .IsRequired();
    }
}