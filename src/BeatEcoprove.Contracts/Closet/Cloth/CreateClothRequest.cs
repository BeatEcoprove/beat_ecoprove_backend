using Microsoft.AspNetCore.Http;

namespace BeatEcoprove.Contracts.Closet.Cloth;

public record CreateClothRequest
(
    string Name,
    string ClothType,
    string ClothSize,
    string Brand,
    string Color,
    IFormFile ClothAvatar);