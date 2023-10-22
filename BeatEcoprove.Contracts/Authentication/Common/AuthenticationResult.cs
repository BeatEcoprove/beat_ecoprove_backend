namespace BeatEcoprove.Contracts.Authentication.Common;

public record AuthenticationResult
(
    string AccessToken,
    string RefreshToken
);