using BeatEcoprove.Domain.ClosetAggregator;
using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Domain.StoreAggregator.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeatEcoprove.Infrastructure.Persistence.Configurations.ServiceProvider;

public class OrderBucketConfiguration : IEntityTypeConfiguration<OrderBucket>
{
    public void Configure(EntityTypeBuilder<OrderBucket> builder)
    {
        builder.Property(orderBucket => orderBucket.Bucket)
            .HasColumnName("bucket")
            .ValueGeneratedNever()
            .HasConversion(
                bucketId => bucketId.Value,
                value => BucketId.Create(value)
            )
            .IsRequired();
        
        builder.HasOne<Bucket>()
            .WithMany()
            .HasForeignKey(orderBucket => orderBucket.Bucket);
    }
}