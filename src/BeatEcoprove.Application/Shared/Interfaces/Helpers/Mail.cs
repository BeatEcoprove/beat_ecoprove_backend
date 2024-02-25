namespace BeatEcoprove.Application.Shared.Interfaces.Helpers;

public record Mail
(
    string To,
    string Subject,
    string Body
);
