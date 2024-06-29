using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.StoreAggregator.Entities;
using BeatEcoprove.Domain.StoreAggregator.ValueObjects;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeatEcoprove.Infrastructure.Persistence.Configurations.Store;

public class WorkerConfiguration : IEntityTypeConfiguration<Worker>
{
    private const string WorkerTable = "workers";
    
    public void Configure(EntityTypeBuilder<Worker> builder)
    {
        builder.ToTable(WorkerTable);
        builder.HasKey(worker => worker.Id);

        builder.Property(worker => worker.Id)
            .HasColumnName("id")
            .ValueGeneratedNever()
            .HasConversion(
                workerId => workerId.Value,
                value => WorkerId.Create(value)
            )
            .IsRequired();

        builder.Property(worker => worker.Store)
            .HasColumnName("store")
            .ValueGeneratedNever()
            .HasConversion(
                storeId => storeId.Value,
                value => StoreId.Create(value)
            )
            .IsRequired();
        
            builder.Property(worker => worker.Profile)
                .HasColumnName("profile")
                .ValueGeneratedNever()
                .HasConversion(
                    storeId => storeId.Value,
                    value => ProfileId.Create(value)
                )
                .IsRequired();

            builder.HasOne<Domain.ProfileAggregator.Entities.Profiles.Profile>()
                .WithMany()
                .HasForeignKey(worker => worker.Profile);

            builder.Property(worker => worker.Role)
                .HasColumnName("role")
                .IsRequired();

            builder.Property(worker => worker.JoinedAt)
                .HasColumnName("joined_at")
                .IsRequired();

            builder.Property(worker => worker.ExitAt)
                .HasColumnName("exit_at");

            builder.Property(worker => worker.DeletedAt)
                .HasColumnName("deleted_at");
    }
}