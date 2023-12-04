namespace BeatEcoprove.Application.Shared.Helpers;

public interface IAuthorization
{
    public Guid AuthId { get; }
    public Guid ProfileId { get; }
}