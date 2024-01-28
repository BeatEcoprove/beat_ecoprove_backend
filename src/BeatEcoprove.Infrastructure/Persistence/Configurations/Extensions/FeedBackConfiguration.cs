using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Entities;
using BeatEcoprove.Domain.Shared.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeatEcoprove.Infrastructure.Persistence.Configurations.Extensions;

public class FeedBackConfiguration : IEntityTypeConfiguration<FeedBack>
{
    private const string FeedBackTable = "feedbacks";
    
    public void Configure(EntityTypeBuilder<FeedBack> builder)
    {
        builder.ToTable(FeedBackTable);
        builder.HasKey(feedback => feedback.Id);

        builder.Property(feedback => feedback.Id)
            .HasColumnName("id")
            .ValueGeneratedNever()
            .HasConversion(
                id => id.Value,
                id => FeedBackId.Create(id)
            );
        
        builder.Property(feedback => feedback.Sender)
            .HasColumnName("sender_id")
            .ValueGeneratedNever()
            .HasConversion(
                id => id.Value,
                id => ProfileId.Create(id)
            );
        
        builder.HasOne<Domain.ProfileAggregator.Entities.Profiles.Profile>()
            .WithMany()
            .HasForeignKey(b => b.Sender);

        builder.Property(feedback => feedback.Title)
            .HasColumnName("title")
            .HasConversion(
                title => title.Value,
                title => Title.Create(title).Value)
            .HasMaxLength(30)
            .IsRequired();
        
        builder.Property(feedback => feedback.Description)
            .HasColumnName("description")
            .IsRequired();
        
        builder.Property(feedback => feedback.DeletedAt)
            .HasColumnName("deleted_at");
    }
}