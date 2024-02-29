using BeatEcoprove.Domain.GroupAggregator.Entities;
using BeatEcoprove.Domain.GroupAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeatEcoprove.Infrastructure.Persistence.Configurations.Groups;

public class GroupInvitationConfiguration : IEntityTypeConfiguration<GroupInvite>
{
    private const string GroupInvitesTable = "group_invites";

    public void Configure(EntityTypeBuilder<GroupInvite> builder)
    {
        builder.ToTable(GroupInvitesTable);
        builder.HasKey(invite => invite.Id);

        builder.Property(invite => invite.Id)
            .HasColumnName("id")
            .ValueGeneratedNever()
            .HasConversion(
                id => id.Value,
                value => InviteGroupId.Create(value));

        builder.Property(invite => invite.Group)
            .HasColumnName("group_id")
            .HasConversion(
                id => id.Value,
                value => GroupId.Create(value));

        builder.Property(invite => invite.Target)
            .HasColumnName("target_id")
            .HasConversion(
                id => id.Value,
                value => ProfileId.Create(value));

        builder.HasOne<Domain.ProfileAggregator.Entities.Profiles.Profile>()
            .WithMany()
            .HasForeignKey(gm => gm.Target);

        builder.Property(invite => invite.Inviter)
            .HasColumnName("inviter_id")
            .HasConversion(
                id => id.Value,
                value => ProfileId.Create(value));

        builder.HasOne<Domain.ProfileAggregator.Entities.Profiles.Profile>()
            .WithMany()
            .HasForeignKey(gm => gm.Inviter);

        builder.Property(g => g.Permission)
            .HasColumnName("permission")
            .IsRequired();

        builder.Property(g => g.CreatedAt)
            .HasColumnName("created_at");

        builder.Property(g => g.AcceptedAt)
            .HasColumnName("accepted_at");

        builder.Property(g => g.DeclinedAt)
            .HasColumnName("declined_at");
    }
}