using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;

namespace BeatEcoprove.Domain.ClosetAggregator.Entities;

public class MaintenanceActivity : Activity
{
    private MaintenanceActivity() { }
    
    private MaintenanceActivity(
        MaintenanceServiceId serviceId,
        MaintenanceActionId actionId,
        ProfileId profileId, 
        ClothId clothId,
        int sustainablePoints,
        float xp = 0, 
        float deltaScore = 0) : base(profileId, clothId, xp, deltaScore)
    {
        ServiceId = serviceId;
        ActionId = actionId;
        SustainablePoints = sustainablePoints;
    }

    public MaintenanceServiceId ServiceId { get; private set; } = null!;
    public MaintenanceActionId ActionId { get; private set; } = null!;
    public int SustainablePoints { get; private set; }

    public static MaintenanceActivity Create(
        MaintenanceServiceId serviceId,
        MaintenanceActionId actionId,
        ProfileId profileId, 
        ClothId clothId,
        int sustainablePoints = 0,
        float xp = 0,
        float deltaScore = 0)
    {
        return new MaintenanceActivity(
            serviceId,
            actionId,
            profileId, 
            clothId, 
            sustainablePoints,
            xp, 
            deltaScore);
    }
}