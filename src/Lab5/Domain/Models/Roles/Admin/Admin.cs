namespace Domain.Models.Roles.Admin;

public class Admin : IRoleModel
{
    public Admin(string systemPassword, int id)
    {
        SystemPassword = systemPassword;
        Id = id;
    }

    public string SystemPassword { get; private set; }
    public int Id { get; init; }
}