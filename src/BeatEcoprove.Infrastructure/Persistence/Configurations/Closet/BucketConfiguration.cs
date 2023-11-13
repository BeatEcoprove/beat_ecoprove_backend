using BeatEcoprove.Domain.ClosetAggregator;
using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeatEcoprove.Infrastructure.Persistence.Configurations.Closet;

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

        builder.OwnsMany(b => b.BucketClothEntries, clothEntries =>
        {
            clothEntries.ToTable("bucket_cloths");
            clothEntries.HasKey(b => new { b.BucketId, b.ClothId });

            clothEntries.WithOwner().HasForeignKey(b => b.BucketId);
            
            clothEntries.Property(b => b.BucketId)
                .HasColumnName("bucket_id")
                .HasConversion(
                    id => id.Value,
                    value => BucketId.Create(value));
            
            clothEntries.Property(b => b.ClothId)
                .HasColumnName("cloth_id")
                .HasConversion(
                    id => id.Value,
                    value => ClothId.Create(value));
        });
    }
}