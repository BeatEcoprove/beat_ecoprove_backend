using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Models;
using BeatEcoprove.Domain.StoreAggregator.ValueObjects;

namespace BeatEcoprove.Domain.StoreAggregator.Entities;

public class Worker : Entity<WorkerId>
{
    private Worker() { }

    private Worker(
        StoreId store, 
        WorkerId id,  
        ProfileId profile,
        WorkerType role)
    {
        Id = id;
        Store = store;
        Profile = profile;
        Role = role;
    }

    public StoreId Store { get; private set; } = null!;
    public ProfileId Profile { get; private set; } = null!;
    public WorkerType Role { get; private set; } = WorkerType.Worker;
    public DateTimeOffset JoinedAt { get; private set; } = DateTimeOffset.Now;
    public DateTimeOffset ExitAt { get; private set; }

    public static Worker Create(StoreId store, ProfileId profile, WorkerType role)
    {
        return new Worker(
            store,
            WorkerId.CreateUnique(),
            profile,
            role
        );
    }

    public void UpgradeRole(WorkerType role)
    {
        Role = role;
    }

    public void Exit()
    {
        ExitAt = DateTimeOffset.Now;
    }
}