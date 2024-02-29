using BeatEcoprove.Application.FeedBacks.Commands.Common;
using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Helpers;

using ErrorOr;

namespace BeatEcoprove.Application.FeedBacks.Commands.SubmitFeedBack;

public record SubmitFeedBackCommand
(
    Guid AuthId,
    Guid ProfileId,
    string Title,
    string Description
) : ICommand<ErrorOr<FeedBackResult>>, IAuthorization;