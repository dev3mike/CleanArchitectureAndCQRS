using Domain.Entities;

namespace Domain.Abstractions;

public interface IUserRepository
{
    void Add(User user);

}