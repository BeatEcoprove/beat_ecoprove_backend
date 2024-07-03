using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;
using BeatEcoprove.Domain.Shared.Models;
using BeatEcoprove.Domain.StoreAggregator.Enumerators;
using BeatEcoprove.Domain.StoreAggregator.ValueObjects;

using ErrorOr;

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
    public DateTimeOffset JoinedAt { get; private set; } = DateTimeOffset.UtcNow;
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

    public ErrorOr<WorkerType> UpgradeRole(WorkerType role)
    {
        if (Role == role)
        {
            return Errors.Worker.CannotChangeToSamePermission;
        }
        
        Role = role;
        return role;
    }

    public void Exit()
    {
        ExitAt = DateTimeOffset.Now;
    }
}