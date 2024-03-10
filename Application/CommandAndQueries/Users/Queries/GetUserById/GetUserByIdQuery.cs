using Application.Abstractions.Messaging;

namespace Application.CommandAndQueries.Users.Queries.GetUserById;

public sealed record GetUserByIdQuery(Guid UserId) : IQuery<GetUserResponse>;

internal sealed class GetUserByIdQueryHandler : IQueryHandler<GetUserByIdQuery, GetUserResponse>
{
    public Task<GetUserResponse> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
    {
        // Fetching user logic
        return Task.FromResult(new GetUserResponse(Guid.NewGuid(), "FirstName", "LastName", "USERNAME", "XXXXXXXXXX"));
    }
}