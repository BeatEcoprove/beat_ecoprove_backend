using BeatEcoprove.Contracts.Authentication.SignIn;

using Microsoft.AspNetCore.Http;

namespace BeatEcoprove.Contracts.Advertisements;

public record CreateAdvertisementRequest
(
    string Title,
    string Description,
    DateOnly BeginAt,
    DateOnly EndAt,
    IFormFile? Picture,
    string Type,
    int Quantity = 0
) : IPictureRequest
{
    public Stream PictureStream => Picture != null ? Picture.OpenReadStream() : Stream.Null;
}