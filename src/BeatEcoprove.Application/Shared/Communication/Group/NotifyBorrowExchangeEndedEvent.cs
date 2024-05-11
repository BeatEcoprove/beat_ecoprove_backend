
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;

namespace BeatEcoprove.Application.Shared.Communication.Group;

public class NotifyBorrowExchangeEndedEvent : NotificationEvent<NotifyBorrowExchangeContent>
{
    public NotifyBorrowExchangeEndedEvent(
        ProfileId owner,
        NotifyBorrowExchangeContent content) : base(owner, content)
    {
    }

    public override string Type => nameof(NotifyBorrowExchangeEndedEvent);
}