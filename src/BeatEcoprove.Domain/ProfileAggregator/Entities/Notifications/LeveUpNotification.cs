using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;

namespace BeatEcoprove.Domain.ProfileAggregator.Entities.Notifications;

public class LeveUpNotification : Notification
{
    private const string Message = "Parabens! Subiu de nível!";

    private LeveUpNotification(ProfileId owner, int level, double xp)
        : base(Message, owner)
    {
        StagedLevel = level;
        StagedXp = xp;
    }

    public int StagedLevel { get; private set; }
    public double StagedXp { get; private set; }

    public static LeveUpNotification Create(ProfileId owner, int level, double xp)
    {
        return new LeveUpNotification(
            owner,
            level, 
            xp
        );
    }
}
