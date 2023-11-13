using Microsoft.AspNetCore.Http;

namespace BeatEcoprove.Contracts.Closet.Cloth;

public record CreateClothRequest
(
    string Name,
    string GarmentType,
    string GarmentSize,
    string Brand,
    string Color,
    IFormFile ClothAvatar);