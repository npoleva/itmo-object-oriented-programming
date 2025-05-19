using Domain.Models.Accounts;

namespace Domain.Models.Roles.Users;

public class User : IRoleModel
{
    public User(int id, Account account)
    {
        Account = account;
        Id = id;
    }

    public Account Account { get; set; }
    public int Id { get; init; }
}