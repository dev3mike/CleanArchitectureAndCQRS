using FluentValidation;

namespace Application.CommandAndQueries.Users.Commands.CreateUser;

public sealed class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
{
    public CreateUserCommandValidator()
    {
        RuleFor(x => x.FirstName).NotEmpty();
        RuleFor(x => x.LastName).NotEmpty();
        RuleFor(x => x.UserName).MinimumLength(6).MaximumLength(20);
        RuleFor(x => x.PasswordHash).NotEmpty();
    }
}