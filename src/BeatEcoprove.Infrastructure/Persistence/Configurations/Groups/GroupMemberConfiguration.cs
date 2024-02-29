using BeatEcoprove.Domain.GroupAggregator.Entities;
using BeatEcoprove.Domain.GroupAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeatEcoprove.Infrastructure.Persistence.Configurations.Groups;

public class GroupMemberConfiguration : IEntityTypeConfiguration<GroupMember>
{
    private const string GroupMemberTable = "group_members";

    public void Configure(EntityTypeBuilder<GroupMember> builder)
    {
        builder.ToTable(GroupMemberTable);
        builder.HasKey(g => g.Id);

        builder.Property(g => g.Id)
            .HasColumnName("id")
            .ValueGeneratedNever()
            .HasConversion(
                groupMemberId => groupMemberId.Value,
                value => GroupMemberId.Create(value));

        builder.Property(g => g.Group)
            .HasColumnName("group_id")
            .ValueGeneratedNever()
            .HasConversion(
                group => group.Value,
                value => GroupId.Create(value));

        builder.Property(g => g.Profile)
            .HasColumnName("profile_id")
            .ValueGeneratedNever()
            .HasConversion(
                profile => profile.Value,
                value => ProfileId.Create(value));

        builder.HasOne<Domain.ProfileAggregator.Entities.Profiles.Profile>()
            .WithMany()
            .HasForeignKey(b => b.Profile);

        builder.Property(g => g.Permission)
            .HasColumnName("permission")
            .IsRequired();
    }
}