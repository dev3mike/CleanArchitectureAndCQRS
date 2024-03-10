namespace Application.CommandAndQueries.Users.Commands.CreateUser;

public sealed record CreateUserRequest(string FirstName, string LastName, string UserName, string PasswordHash);