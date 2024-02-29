using BeatEcoprove.Domain.AuthAggregator;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.ClosetAggregator;
using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.ProfileAggregator.Enumerators;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Infrastructure.Persistence.Converters;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeatEcoprove.Infrastructure.Persistence.Configurations.Profile;

public class ProfileConfiguration : IEntityTypeConfiguration<Domain.ProfileAggregator.Entities.Profiles.Profile>
{
    private const string ProfileTable = "profiles";
    private const string ClothEntryTable = "cloth_entries";
    private const string BucketEntryTable = "bucket_entries";

    public void Configure(EntityTypeBuilder<Domain.ProfileAggregator.Entities.Profiles.Profile> builder)
    {
        ConfigureProfile(builder);
        ConfigureClothEntry(builder);
        ConfigureBucketEntry(builder);
    }

    private static void ConfigureBucketEntry(EntityTypeBuilder<Domain.ProfileAggregator.Entities.Profiles.Profile> builder)
    {
        builder.OwnsMany(p => p.BucketEntries, bucketEntry =>
        {
            bucketEntry.ToTable(BucketEntryTable);
            bucketEntry.HasKey(b => new { b.ProfileId, Bucket = b.BucketId });

            bucketEntry.Property(b => b.ProfileId)
                .HasColumnName("profile_id")
                .ValueGeneratedNever()
                .HasConversion(
                    profileId => profileId.Value,
                    value => ProfileId.Create(value));

            bucketEntry.Property(b => b.DeletedAt)
                .HasColumnName("deleted_at");

            bucketEntry.Property(b => b.BucketId)
                .HasColumnName("bucket_id")
                .ValueGeneratedNever()
                .HasConversion(
                    bucketId => bucketId.Value,
                    value => BucketId.Create(value));

            bucketEntry.Property(c => c.IsBlocked)
                .HasColumnName("is_blocked")
                .IsRequired();
        });
    }

    private static void ConfigureClothEntry(EntityTypeBuilder<Domain.ProfileAggregator.Entities.Profiles.Profile> builder)
    {
        builder.OwnsMany(p => p.ClothEntries, clothEntry =>
        {
            clothEntry.ToTable(ClothEntryTable);
            clothEntry.HasKey(c => new { c.ProfileId, Cloth = c.ClothId });
            clothEntry.WithOwner().HasForeignKey(c => c.ProfileId);

            clothEntry.Property(c => c.ProfileId)
                .HasColumnName("profile_id")
                .ValueGeneratedNever()
                .HasConversion(
                    profileId => profileId.Value,
                    value => ProfileId.Create(value));

            clothEntry.Property(c => c.DeletedAt)
                .HasColumnName("deleted_at");

            clothEntry.Property(c => c.ClothId)
                .HasColumnName("cloth_id")
                .ValueGeneratedNever()
                .HasConversion(
                    clothId => clothId.Value,
                    value => ClothId.Create(value));

            clothEntry.HasOne<Cloth>()
                .WithMany()
                .HasForeignKey(b => b.ClothId);

            clothEntry.Property(c => c.IsBlocked)
                .HasColumnName("is_blocked")
                .IsRequired();
        });
    }

    private static void ConfigureProfile(EntityTypeBuilder<Domain.ProfileAggregator.Entities.Profiles.Profile> builder)
    {
        builder.ToTable(ProfileTable);
        builder.HasKey(profile => profile.Id);

        builder.Property(profile => profile.DeletedAt)
            .HasColumnName("deleted_at");

        builder.Property(profile => profile.Id)
            .HasColumnName("Id")
            .ValueGeneratedNever()
            .HasConversion(
                id => id.Value,
                value => ProfileId.Create(value));

        builder.HasOne<Auth>()
            .WithMany()
            .HasForeignKey(t => t.AuthId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Restrict);

        builder.Property(profile => profile.AuthId)
            .HasColumnName("auth_id")
            .HasConversion(
                authId => authId.Value,
                value => AuthId.Create(value));

        builder.HasDiscriminator(u => u.Type)
            .HasValue<Consumer>(UserType.Consumer)
            .HasValue<Organization>(UserType.Organization);

        builder.Property(a => a.Type)
            .HasColumnName("type")
            .HasConversion(new UserTypeConverter())
            .IsRequired();

        builder.Property(profile => profile.Level)
            .HasColumnName("level")
            .IsRequired();

        builder.Property(profile => profile.EcoCoins)
            .HasColumnName("eco_coins")
            .IsRequired();

        builder.Property(profile => profile.UserName)
            .HasColumnName("user_name")
            .HasMaxLength(256)
            .HasConversion(
                userName => userName.Value,
                value => UserName.Create(value).Value);

        builder.OwnsOne(u => u.Phone, p =>
        {
            p.Property(pp => pp.Code)
                .HasColumnName("phone_country_code")
                .IsRequired()
                .HasMaxLength(4);

            p.Property(pp => pp.Value)
                .HasColumnName("phone")
                .IsRequired()
                .HasMaxLength(256);
        });

        builder.Property(profile => profile.XP)
            .HasColumnName("xp");

        builder.Property(profile => profile.SustainabilityPoints)
            .HasColumnName("sustainability_points");

        builder.Property(profile => profile.EcoScore)
            .HasColumnName("eco_score");

        builder.Property(profile => profile.AvatarUrl)
            .HasColumnName("avatar_url")
            .HasMaxLength(256)
            .IsRequired();

        builder.HasQueryFilter(b => b.BucketEntries.All(be => be.DeletedAt == null));
        builder.HasQueryFilter(b => b.ClothEntries.All(be => be.DeletedAt == null));
    }
}