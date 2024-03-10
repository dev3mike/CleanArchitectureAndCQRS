namespace Application.CommandAndQueries.Users.Queries.GetUserById;

public sealed record GetUserResponse(Guid Id, string FirstName, string LastName, string UserName, string PasswordHash);