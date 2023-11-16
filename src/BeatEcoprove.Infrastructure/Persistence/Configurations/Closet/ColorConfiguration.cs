using BeatEcoprove.Domain.ClosetAggregator;
using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeatEcoprove.Infrastructure.Persistence.Configurations.Closet;

public class ColorConfiguration : IEntityTypeConfiguration<Color>
{
    private const string ColorTable = "colors";
    
    public void Configure(EntityTypeBuilder<Color> builder)
    {
        builder.ToTable(ColorTable);
        builder.HasKey(cl => cl.Id);

        builder.Property(cl => cl.Id)
            .HasColumnName("id")
            .ValueGeneratedNever()
            .HasConversion(
                id => id.Value,
                value => ColorId.Create(value));
        
        builder.Property(cl => cl.Name)
            .HasColumnName("name")
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(cl => cl.Hex)
            .HasColumnName("hex")
            .HasMaxLength(8)
            .IsRequired();
    }
}