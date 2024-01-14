using BeatEcoprove.Domain.GroupAggregator.Entities;
using BeatEcoprove.Domain.GroupAggregator.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeatEcoprove.Infrastructure.Persistence.Configurations.Groups;

public class GroupMessageConfiguration : IEntityTypeConfiguration<TextMessage>
{
    private const string GroupTextMessagesTable = "group_text_messages";
    
    public void Configure(EntityTypeBuilder<TextMessage> builder)
    {
        builder.ToTable(GroupTextMessagesTable);
        builder.HasKey(message => message.Id);
        
        builder.Property(message => message.Id)
            .HasColumnName("id")
            .ValueGeneratedNever()
            .HasConversion(
            id => id.Value, 
            value => MessageId.Create(value));

        builder.Property(message => message.Group)
            .HasColumnName("group_id")
            .HasConversion(
                id => id.Value,
                value => GroupId.Create(value));
        
        builder.Property(message => message.Sender) 
            .HasColumnName("sender_id")
            .HasConversion(
                id => id.Value,
                value => GroupMemberId.Create(value));
        
        builder.HasOne<GroupMember>()
            .WithMany()
            .HasForeignKey(gm => gm.Sender);
        
        builder.Property(message => message.Content)    
            .HasColumnName("content")
            .HasMaxLength(500)
            .IsRequired();
    }
}