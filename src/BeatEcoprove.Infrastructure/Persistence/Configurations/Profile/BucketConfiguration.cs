using BeatEcoprove.Domain.ProfileAggregator.Entities.Cloths;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeatEcoprove.Infrastructure.Persistence.Configurations.Profile;

public class BucketConfiguration : IEntityTypeConfiguration<Bucket>
{
    private const string BucketTable = "buckets";
    
    public void Configure(EntityTypeBuilder<Bucket> builder)
    {
        builder.ToTable(BucketTable);
        builder.HasKey(b => b.Id);

        builder.Property(b => b.Id)
            .HasColumnName("id")
            .ValueGeneratedNever()
            .HasConversion(
                id => id.Value,
                value => BucketId.Create(value));

        builder.Property(b => b.Name)
            .HasColumnName("name")
            .HasMaxLength(50)
            .IsRequired();
    }
}