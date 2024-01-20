namespace BeatEcoprove.Application.Closet.Common;

public interface IClothResult
{
    public Guid Id { get; init; }
    public string Name { get; init; }
    public string Type { get; init; }
    public string Size { get; init; }
    public string Brand { get; init; }
    public string Color { get; init; }
    public int EcoScore { get; init; }
    public string ClothState { get; init; }
    public string ClothAvatar { get; init; }
}