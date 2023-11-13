using Microsoft.AspNetCore.Http;

namespace BeatEcoprove.Contracts.Profile;

public record AddClothToProfile
(
    string Name,
    string GarmentType,
    string GarmentSize,
    string Brand,
    string Color,
    IFormFile ClothAvatar);