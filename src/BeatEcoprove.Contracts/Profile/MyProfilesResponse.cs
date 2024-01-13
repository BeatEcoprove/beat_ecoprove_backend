namespace BeatEcoprove.Contracts.Profile;

public record MyProfilesResponse
(
    ProfileResponse MainProfile,
    List<ProfileResponse> NestedProfiles
);