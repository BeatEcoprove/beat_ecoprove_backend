using BeatEcoprove.Domain.ClosetAggregator.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeatEcoprove.Infrastructure.Persistence.Configurations.Closet;

public class DailyUseActivityConfiguration : IEntityTypeConfiguration<DailyUseActivity>
{
    private const string DailyUseActivityTableName = "daily_use_activities";

    public void Configure(EntityTypeBuilder<DailyUseActivity> builder)
    {
        builder.ToTable(DailyUseActivityTableName);

        builder.Property(daily => daily.DailySequence)
            .HasColumnName("daily_sequence")
            .IsRequired();

        builder.Property(daily => daily.PointsOfSustentability)
            .HasColumnName("points_of_sustainability")
            .IsRequired();

        builder.Property(daily => daily.DeletedAt)
            .HasColumnName("deleted_at");
    }
}