using BeatEcoprove.Application.Shared;

namespace BeatEcoprove.Application.Groups.Queries.ConnectToGroup;

internal class ConnectToGroupQueryHandler : IQueryHandler<ConnectToGroupQuery, string>
{
    public Task<string> Handle(ConnectToGroupQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
