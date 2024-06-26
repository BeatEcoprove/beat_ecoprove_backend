using BeatEcoprove.Application.Groups.Queries.GetGroupMessages.Common;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Contracts.Groups;
using BeatEcoprove.Contracts.Profile;
using BeatEcoprove.Domain.GroupAggregator;
using BeatEcoprove.Domain.GroupAggregator.DAOS;

using Mapster;

namespace BeatEcoprove.Api.Mappers;

public class GroupMappingConfiguration : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<Group, GroupResponse>();
        config.NewConfig<MessageResult, TextMessageResponse>()
            .MapWith(src => new TextMessageResponse(
                src.Id,
                src.GroupId,
                src.Sender.Adapt<ProfileResponse>(),
                src.Content,
                src.CreatedAt,
                src.Type
            ));

        config.NewConfig<BorrowMessageResult, BorrowMessageResponse>()
            .MapWith(src => new BorrowMessageResponse(
            src.Id,
            src.GroupId,
            src.Sender.Adapt<ProfileResponse>(),
            src.Content,
            src.CreatedAt,
            new BorrowResult(
                src.Borrow.Avatar,
                src.Borrow.Title,
                src.Borrow.Brand,
                src.Borrow.Color,
                src.Borrow.Size,
                src.Borrow.EcoScore
            ),
            src.IsAccepted,
            src.Type));

        config.NewConfig<GetGroupList, GetGroupsResponse>()
            .MapWith(dest => new GetGroupsResponse(
                dest.Public.Adapt<List<GroupResponse>>(),
                dest.MyPrivateGroups.Adapt<List<GroupResponse>>()));

        config.NewConfig<GroupDao, GetGroupDetailResponse>()
            .MapWith(src => new GetGroupDetailResponse(
                src.Id,
                src.Name,
                src.Description,
                src.MembersCount,
                src.SustainablePoints,
                src.Xp,
                src.IsPublic,
                src.AvatarPicture,
                src.Creator.Adapt<ProfileResponse>(),
                src.Members.Adapt<List<ProfileResponse>>(),
                src.Admins.Adapt<List<ProfileResponse>>())
            );
    }
}