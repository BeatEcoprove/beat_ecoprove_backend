using BeatEcoprove.Domain.ClosetAggregator.Entities;
using BeatEcoprove.Domain.ClosetAggregator.Enumerators;
using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Infrastructure.Persistence.Converters;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeatEcoprove.Infrastructure.Persistence.Configurations.Closet;

public class ActivityConfiguration : IEntityTypeConfiguration<Activity>
{
    private const string ActivityTableName = "activities";
    
    public void Configure(EntityTypeBuilder<Activity> builder)
    {
        builder.ToTable(ActivityTableName);
        builder.HasKey(activity => activity.Id);

        builder.Property(activity => activity.Id)
            .HasColumnName("id")
            .ValueGeneratedNever()
            .HasConversion(
                id => id.Value,
                value => ActivityId.Create(value));
    
        builder.Property(activity => activity.ClothId)
            .HasColumnName("cloth_id")
            .ValueGeneratedNever()
            .HasConversion(
                clothId => clothId.Value,
                value => ClothId.Create(value))
            .IsRequired();
        
        builder.HasOne<Domain.ProfileAggregator.Entities.Profiles.Profile>()
            .WithMany()
            .HasForeignKey(b => b.ProfileId);
        
        builder.Property(activity => activity.DeletedAt)
            .HasColumnName("deleted_at");
        
        builder.Property(activity => activity.ProfileId)
            .HasColumnName("profile_id")
            .ValueGeneratedNever()
            .HasConversion(
                profileId => profileId.Value,
                value => ProfileId.Create(value))
            .IsRequired();

        builder.Property(activity => activity.XP)
            .HasColumnName("xp")
            .IsRequired();

        builder.Property(activity => activity.DeltaScore)
            .HasColumnName("delta_score")
            .IsRequired();

        builder.Property(activity => activity.CreatedAt)
            .HasColumnName("created_at")
            .IsRequired();
        
        builder.Property(activity => activity.EndAt)
            .HasColumnName("end_at")
            .IsRequired();
    }
}