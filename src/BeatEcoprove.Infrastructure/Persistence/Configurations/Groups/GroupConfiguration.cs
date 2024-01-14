using BeatEcoprove.Domain.GroupAggregator;
using BeatEcoprove.Domain.GroupAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeatEcoprove.Infrastructure.Persistence.Configurations.Groups;

public class GroupConfiguration : IEntityTypeConfiguration<Group>
{
    private const string GroupTable = "groups";
    
    public void Configure(EntityTypeBuilder<Group> builder)
    {
        builder.ToTable(GroupTable);
        builder.HasKey(g => g.Id);
        
        builder.Property(g => g.Id)
            .HasColumnName("id")
            .ValueGeneratedNever()
            .HasConversion(
                groupId => groupId.Value,
                value => GroupId.Create(value));
        
        builder.Property(g => g.CreatorId) 
            .HasColumnName("creator_id")
            .ValueGeneratedNever()
            .HasConversion(
                creatorId => creatorId.Value,
                value => ProfileId.Create(value));
        
        builder.HasOne<Domain.ProfileAggregator.Entities.Profiles.Profile>()
            .WithMany()
            .HasForeignKey(t => t.CreatorId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Restrict);
        
        builder.Property(g => g.Name)
            .HasColumnName("name")
            .HasMaxLength(50)
            .IsRequired();
        
        builder.Property(g => g.Description)    
            .HasColumnName("description")
            .HasMaxLength(500)
            .IsRequired();
        
        builder.Property(g => g.MembersCount)    
            .HasColumnName("members_count")
            .IsRequired();
        
        builder.Property(g => g.SustainablePoints)  
            .HasColumnName("sustainable_points")
            .IsRequired();
        
        builder.Property(g => g.Xp) 
            .HasColumnName("xp")
            .IsRequired();
        
        builder.Property(g => g.IsPublic) 
            .HasColumnName("is_public")
            .IsRequired();
        
        builder.Property(g => g.AvatarPicture)  
            .HasColumnName("avatar_picture")
            .HasMaxLength(256)
            .IsRequired();

        builder.HasMany(group => group.Members)
            .WithOne()
            .HasForeignKey(groupMember => groupMember.Group);       
        
        builder.HasMany(group => group.TextMessages)
            .WithOne()
            .HasForeignKey(textMessage => textMessage.Group);
    }
}