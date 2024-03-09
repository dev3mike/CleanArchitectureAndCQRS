using Domain.Primitives;

namespace Domain.Entities;

public class User : Entity
{
    public User(Guid id, string firstName, string lastName, string userName, string passwordHash) : base(id)
    {
        FirstName = firstName;
        LastName = lastName;
        UserName = userName;
        PasswordHash = passwordHash;
    }

    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string UserName { get; private set; }
    public string PasswordHash { get; private set; }
}