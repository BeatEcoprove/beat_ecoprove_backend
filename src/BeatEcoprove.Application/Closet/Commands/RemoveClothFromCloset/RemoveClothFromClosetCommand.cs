using BeatEcoprove.Application.Closet.Common;
using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Helpers;
using ErrorOr;

namespace BeatEcoprove.Application.Closet.Commands.RemoveClothFromCloset;

public record RemoveClothFromClosetCommand
(
    Guid AuthId,
    Guid ProfileId,
    Guid ClothId
) : ICommand<ErrorOr<ClothResult>>, IAuthorization;