using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.StoreAggregator.Entities;
using BeatEcoprove.Domain.StoreAggregator.ValueObjects;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeatEcoprove.Infrastructure.Persistence.Configurations.ServiceProvider;

public class RatingConfiguration : IEntityTypeConfiguration<Rating>
{
    private const string RatingTable = "store_ratings";
    
    public void Configure(EntityTypeBuilder<Rating> builder)
    {
        builder.ToTable(RatingTable);
        builder.HasKey(rating => new { rating.Store, rating.User });

        builder.Property(rating => rating.Store)
            .HasColumnName("store")
            .ValueGeneratedNever()
            .HasConversion(
                storeId => storeId.Value,
                value => StoreId.Create(value)
            ).IsRequired();

        builder.Property(rating => rating.User)
            .HasColumnName("user")
            .ValueGeneratedNever()
            .HasConversion(
                userId => userId.Value,
                value => ProfileId.Create(value)
            ).IsRequired();

        builder.HasOne<Domain.ProfileAggregator.Entities.Profiles.Profile>()
            .WithMany()
            .HasForeignKey(rating => rating.User);

        builder.Property(rating => rating.Rate)
            .HasColumnName("rate")
            .IsRequired();

        builder.Property(rating => rating.PublishAt)
            .HasColumnName("publish_at")
            .IsRequired();

        builder.Property(rating => rating.DeletedAt)
            .HasColumnName("deleted_at");
    }
}