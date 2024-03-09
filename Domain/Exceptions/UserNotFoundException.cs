using Domain.Exceptions.Base;

namespace Domain.Exceptions;

public class UserNotFoundException : NotFoundException
{
    public UserNotFoundException(Guid userId) : base($"The user couldn't be found, Id={userId}")
    {
    }
}