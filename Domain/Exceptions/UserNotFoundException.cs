using System.Linq.Expressions;
using Domain.Exceptions.Base;

namespace Domain.Exceptions;

public class UserNotFoundException : NotFoundException
{
    private static readonly Func<Guid, string> ExceptionMessage = (Guid userId) => $"The user couldn't be found, Id={userId}";
    
    public UserNotFoundException(Guid userId) : base(ExceptionMessage(userId))
    {
    }
}